"""
Parses Tractatus Logico-Philosophicus HTML pages from wittgensteinproject.org (tree-like view)
and converts them into structured JSON files for the Tractatus web explorer.

Usage:
  python tractatus-html-to-json.py <url> <language_key> <display_name> [--source_info "Source"] [--is_structure_source]

Arguments:
  url:                    URL of the Tractatus page (e.g., a tree-like view from wittgensteinproject.org).
  language_key:           A short, unique key for this language version (e.g., "germanOriginal", "englishOgden").
                          This key will be used for the output JSON filename (e.g., "germanOriginal.json").
  display_name:           User-friendly display name for the language switcher (e.g., "German (Original 1921)", "English (Ogden 1922)").

Optional Arguments:
  --source_info "Text":   Information about the source/translator (e.g., "L. Wittgenstein", "Translated by C.K. Ogden").
                          Defaults to "Source details not specified".
  --is_structure_source:  Flag to indicate that this URL should be used as the canonical source for the
                          overall structure of the propositions (outputs structure.json).
                          Only use this for ONE language version (typically the primary German version).

Output:
  - structure.json:           If --is_structure_source is used, this file defines the hierarchical structure (Id, Children).
  - <language_key>.json:      A JSON file mapping proposition IDs to their text for the specified language.
  - language-info.json:       An array of metadata for all processed languages (updated with each run).
  - found_images.json:        A JSON file containing a list of all unique image URLs found during parsing.

Example Full Commands:
  # German (Original - used as the source for structure.json)
  python tractatus-html-to-json.py "https://www.wittgensteinproject.org/w/index.php/Logisch-philosophische_Abhandlung_(Darstellung_in_Baumstruktur)" "germanOriginal" "German (Original)" --source_info "L. Wittgenstein" --is_structure_source

  # English (Ogden/Ramsey 1922)
  python tractatus-html-to-json.py "https://www.wittgensteinproject.org/w/index.php/Tractatus_Logico-Philosophicus_(tree-like_view)" "englishOgdenRamsey" "English (Ogden/Ramsey 1922)" --source_info "Translated by F. P. Ramsey and C. K. Ogden, 1922"

  # French (Granger)
  python tractatus-html-to-json.py "https://www.wittgensteinproject.org/w/index.php/Tractatus_logico-philosophicus_(version_arborescente_interactive)" "frenchGranger" "French (Granger)" --source_info "Translated by G. G. Granger"

  # Italian (Lavazza)
  python tractatus-html-to-json.py "https://www.wittgensteinproject.org/w/index.php/Tractatus_logico-philosophicus_(visualizzazione_ad_albero)" "italianLavazza" "Italian (Lavazza)" --source_info "Translated by M. Lavazza"

  # Spanish (Buscató)
  python tractatus-html-to-json.py "https://www.wittgensteinproject.org/w/index.php/Tratado_l%C3%B3gico-filos%C3%B3fico_(presentaci%C3%B3n_en_%C3%A1rbol)" "spanishBuscato" "Spanish (Buscató)" --source_info "Translated by A. G. Buscató"

  # Portuguese (Giannotti)
  python tractatus-html-to-json.py "https://www.wittgensteinproject.org/w/index.php/Tractatus_Logico-Philosophicus_(visualiza%C3%A7%C3%A3o_em_%C3%A1rvore)" "portugueseGiannotti" "Portuguese (Giannotti)" --source_info "Translated by J. A. Giannotti"

"""
import requests
from bs4 import BeautifulSoup, NavigableString
import json
import argparse
import os
import sys
import re

OUTPUT_DIR = 'wwwroot/data/'
# Path to the directory where local SVG images are stored, relative to the script's execution directory
# or an absolute path if preferred. Assuming script runs from project root.
SVG_IMG_DIR = 'wwwroot/image/tractatus/'
STRUCTURE_FILE_NAME = 'structure.json'
LANGUAGE_INFO_FILE_NAME = 'language-info.json'
FOUND_IMAGES_FILE_NAME = 'found_images.json'

# Map specific remote image URLs to local SVG filenames
# The key is the part of the URL that uniquely identifies the image.
# The value is the filename of the SVG in SVG_IMG_DIR.
# Example: "TLP_5.5423.png" -> "TLP_5.5423.svg"
SVG_REPLACEMENTS = {
    "TLP_5.5423.png": "TLP_5.5423.svg",    # Necker Cube
    "TLP_5.6331.png": "TLP_5.6331.svg",    # Eye
    "TLP_6.1203a.png": "TLP_6.1203a.svg",  # curves
    "TLP_6.1203b.png": "TLP_6.1203b.svg",  # labeled
    "TLP_6.1203c.png": "TLP_6.1203c.svg",  # negation
    "TLP_6.1203d.png": "TLP_6.1203d.svg",  # symbols
    "TLP_6.1203e.png": "TLP_6.1203e.svg",  # c + d
    "TLP_6.36111.png": "TLP_6.36111.svg",  # oax xbo
    # Add other mappings here as SVGs are created
}

# Helper function to get 2-letter language code
def get_lang_code(lang_key):
    """Extracts a 2-letter language code from the language key."""
    if not lang_key:
        return None
    key_lower = lang_key.lower()
    if "german" in key_lower:
        return "de"
    if "english" in key_lower:
        return "en"
    if "french" in key_lower:
        return "fr"
    if "italian" in key_lower:
        return "it"
    if "spanish" in key_lower:
        return "es"
    if "portuguese" in key_lower:
        return "pt"
    # Add more mappings if needed, or a more generic approach
    print(f"Warning: Could not determine 2-letter lang code for '{lang_key}'. Defaulting to 'en'.", file=sys.stderr)
    return "en" # Default fallback, consider if this is appropriate

# Updated Helper function to try and load a local SVG with fallback logic
def try_load_local_svg(base_svg_filename_from_map, image_subfolder, current_lang_code, svg_img_root_dir):
    """
    Tries to load an SVG file with comprehensive fallback logic.
    - base_svg_filename_from_map: e.g., "TLP_5.6331.svg" (from SVG_REPLACEMENTS)
    - image_subfolder: e.g., e.g., "germanOriginal", "englishOgdenRamsey", or None
    - current_lang_code: e.g., "de", "en"
    - svg_img_root_dir: e.g., "wwwroot/image/tractatus/"
    Returns the path to the found SVG, or None.
    """
    if not base_svg_filename_from_map:
        return None

    base_name_no_ext, _ = os.path.splitext(base_svg_filename_from_map) # e.g., "TLP_5.6331"

    # List of filenames to try, in order of preference
    filenames_to_try = []
    # 1. Language-specific (e.g., TLP_5.6331.de.svg)
    filenames_to_try.append(f"{base_name_no_ext}.{current_lang_code}.svg")
    # 2. English-specific (if not already the current language)
    if current_lang_code != "en":
        filenames_to_try.append(f"{base_name_no_ext}.en.svg")
    # 3. Generic (from SVG_REPLACEMENTS map, e.g., TLP_5.6331.svg)
    filenames_to_try.append(base_svg_filename_from_map)

    # List of directories to check, in order of preference
    dirs_to_check = []
    if image_subfolder: # If a language-specific subfolder is provided
        dirs_to_check.append(os.path.join(svg_img_root_dir, image_subfolder))
    dirs_to_check.append(svg_img_root_dir) # Always check the root SVG directory

    for filename in filenames_to_try:
        for directory in dirs_to_check:
            potential_path = os.path.join(directory, filename)
            if os.path.exists(potential_path):
                # print(f"Found SVG: {potential_path}") # For debugging
                return potential_path
    
    return None

# Helper function to normalize proposition IDs
def normalize_proposition_id(raw_id):
    if not raw_id:
        return ""
    parts = raw_id.split('.')
    normalized_parts = []
    for part in parts:
        if part.isdigit() and len(part) > 1:
            normalized_parts.append('.'.join(list(part)))
        else:
            normalized_parts.append(part)
    return '.'.join(normalized_parts)

def get_soup(url):
    try:
        headers = {
            'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36'
        }
        response = requests.get(url, headers=headers, timeout=20)
        response.raise_for_status()
        return BeautifulSoup(response.content, 'html.parser')
    except requests.RequestException as e:
        print(f"Error fetching URL {url}: {e}", file=sys.stderr)
        return None

def parse_tlp_page(soup, lang_key_for_debug_logging, image_src_set, image_folder_for_current_lang, current_lang_code):
    propositions = {}
    structure_data_top_level = []

    # --- BEGIN PREFACE PARSING ---
    preface_text_parts = []
    preface_found = False
    preface_p_tag = None

    # Find the <p><i>Preface</i></p> tag
    all_p_tags = soup.find_all('p')
    for p_tag in all_p_tags:
        i_tag = p_tag.find('i')
        known_preface_titles = ['preface', 'vorwort', 'avant-propos', 'prefazione', 'prólogo', 'prefácio']
        if i_tag and i_tag.get_text(strip=True).lower() in known_preface_titles: 
            preface_p_tag = p_tag
            preface_found = True
            break

    if preface_found and preface_p_tag:
        current_tag = preface_p_tag.find_next_sibling()
        while current_tag:
            if current_tag.name == 'p':
                # Stop if we hit the "L.W." paragraph or the date
                if "L.W." in current_tag.get_text() or re.match(r'\w+, \d{4}\.?', current_tag.get_text(strip=True)):
                    break
                preface_text_parts.append(current_tag.get_text(separator=' ', strip=True))
            elif current_tag.name == 'hr': # Stop at the <hr />
                break
            current_tag = current_tag.find_next_sibling()
        
        if preface_text_parts:
            full_preface_text = ' '.join(preface_text_parts)
            full_preface_text = re.sub(r'\s+', ' ', full_preface_text).strip()
            if full_preface_text:
                propositions["Preface"] = full_preface_text
                print(f"Extracted Preface for {lang_key_for_debug_logging}: {full_preface_text[:100]}...")
            else:
                print(f"Preface paragraph texts were empty for {lang_key_for_debug_logging}.")
        else:
            print(f"Found Preface title, but no subsequent content paragraphs for {lang_key_for_debug_logging}.")
    else:
        print(f"Preface not found for {lang_key_for_debug_logging}.")
    # --- END PREFACE PARSING ---

    # Use the correct main container class
    main_content_container = soup.find('div', class_='tree-like-tlp-container')
    if not main_content_container:
        print(f"Could not find 'div.tree-like-tlp-container' for {lang_key_for_debug_logging}. Check HTML structure.", file=sys.stderr)
        return {}, []

    def process_drawers(parent_element, current_level_struct_list):
        # Use the correct drawer class and find direct children only
        drawers = parent_element.find_all('div', class_='tlp-drawer', recursive=False)
        
        for drawer in drawers:
            # The proposition ID and text are usually in the first direct child div of tlp-drawer
            first_child_div = drawer.find('div', recursive=False)
            if not first_child_div:
                # This drawer might be a container for other drawers without its own text
                # (e.g. the tlp-children-X.X divs)
                # So, try to process its children directly if any.
                # If it's an empty tlp-children-X.X div, this will do nothing.
                process_drawers(drawer, current_level_struct_list)
                continue

            prop_id_span = first_child_div.find('span', class_='tlp-aside-par')

            if prop_id_span and prop_id_span.has_attr('id'):
                raw_prop_id = prop_id_span['id']
                prop_id = normalize_proposition_id(raw_prop_id)
                
                if not prop_id: 
                    print(f"Skipping empty prop_id for raw '{raw_prop_id}' in {lang_key_for_debug_logging}", file=sys.stderr)
                    continue

                # Extract text:
                # Create a temporary copy of the first_child_div to manipulate for text extraction
                temp_text_container = BeautifulSoup(str(first_child_div), 'html.parser').div
                
                # Remove button span
                button_span = temp_text_container.find('span', class_='tlp-button')
                if button_span:
                    button_span.decompose()
                
                # Remove the <b> tag containing the tlp-aside-par span (which is the ID)
                id_b_tag = temp_text_container.find('b')
                if id_b_tag and id_b_tag.find('span', class_='tlp-aside-par'):
                    id_b_tag.decompose()
                
                # Remove footnote <sup> tags
                for sup_tag in temp_text_container.find_all('sup', class_='reference'):
                    sup_tag.decompose()

                # New text extraction logic to preserve images and make their URLs absolute
                content_html_parts = []
                for content_child in temp_text_container.children:
                    if isinstance(content_child, NavigableString):
                        content_html_parts.append(str(content_child))
                    elif content_child.name == 'div' and 'center' in content_child.get('class', []):
                        img_tag = content_child.find('img')
                        if img_tag and img_tag.has_attr('src'):
                            src = img_tag['src']
                            absolute_src = src
                            if src.startswith('/w/'):
                                absolute_src = f"https://www.wittgensteinproject.org{src}"
                            
                            # image_filename_part = os.path.basename(absolute_src).split('?')[0] # Old way
                            basename = os.path.basename(absolute_src).split('?')[0]
                            match = re.match(r"\d+px-(.+)", basename)
                            if match:
                                image_filename_part_from_url = match.group(1)
                            else:
                                image_filename_part_from_url = basename

                            # Normalize image_filename_part_from_url to match keys in SVG_REPLACEMENTS
                            # e.g., "TLP_5.6331en.png" -> "TLP_5.6331.png"; "TLP_6.1203d-en.png" -> "TLP_6.1203d.png"
                            normalized_key_for_map = re.sub(r'(-?)(en|de|fr|it|es|pt)\.png$', '.png', image_filename_part_from_url, flags=re.IGNORECASE)
                            
                            # Check if the original or normalized key is in SVG_REPLACEMENTS
                            actual_key_found = None
                            if image_filename_part_from_url in SVG_REPLACEMENTS:
                                actual_key_found = image_filename_part_from_url
                            elif normalized_key_for_map in SVG_REPLACEMENTS:
                                actual_key_found = normalized_key_for_map

                            if actual_key_found:
                                base_svg_filename_from_map = SVG_REPLACEMENTS[actual_key_found]
                                
                                chosen_local_svg_path = try_load_local_svg(
                                    base_svg_filename_from_map, 
                                    image_folder_for_current_lang, 
                                    current_lang_code, 
                                    SVG_IMG_DIR
                                )

                                if chosen_local_svg_path:
                                    try:
                                        with open(chosen_local_svg_path, 'r', encoding='utf-8') as f_svg:
                                            svg_content = f_svg.read()
                                        # Create a new soup for the div.center and replace its content with the SVG
                                        wrapper_div = soup.new_tag('div', **{'class': 'center'})
                                        wrapper_div.append(BeautifulSoup(svg_content, 'html.parser'))
                                        content_html_parts.append(str(wrapper_div))
                                        print(f"Replaced image {absolute_src} with local SVG: {chosen_local_svg_path} for lang {lang_key_for_debug_logging}")
                                    except Exception as e_svg:
                                        print(f"Error processing SVG file {chosen_local_svg_path}: {e_svg}. Using remote image {absolute_src}.", file=sys.stderr)
                                        image_src_set.add(absolute_src)
                                        img_tag['src'] = absolute_src
                                        content_html_parts.append(str(content_child))
                                else:
                                    # SVG not found through any fallback, use remote
                                    print(f"No suitable local SVG found for URL part '{image_filename_part_from_url}' (map key used: '{actual_key_found}', lang: '{current_lang_code}', folder: '{image_folder_for_current_lang}'). Using remote image {absolute_src} as fallback.", file=sys.stderr)
                                    image_src_set.add(absolute_src) 
                                    img_tag['src'] = absolute_src 
                                    content_html_parts.append(str(content_child))
                            else:
                                img_tag['src'] = absolute_src
                                image_src_set.add(absolute_src)
                                content_html_parts.append(str(content_child))
                        else: 
                            content_html_parts.append(str(content_child))
                    elif content_child.name == 'figure' and 'mw-halign-center' in content_child.get('class', []):
                        img_tag = content_child.find('img')
                        if img_tag and img_tag.has_attr('src'):
                            src = img_tag['src']
                            absolute_src = src
                            if src.startswith('/w/'):
                                absolute_src = f"https://www.wittgensteinproject.org{src}"

                            # image_filename_part = os.path.basename(absolute_src).split('?')[0] # Old way
                            basename = os.path.basename(absolute_src).split('?')[0]
                            match = re.match(r"\d+px-(.+)", basename)
                            if match:
                                image_filename_part_from_url = match.group(1)
                            else:
                                image_filename_part_from_url = basename

                            normalized_key_for_map = re.sub(r'(-?)(en|de|fr|it|es|pt)\.png$', '.png', image_filename_part_from_url, flags=re.IGNORECASE)
                            
                            actual_key_found = None
                            if image_filename_part_from_url in SVG_REPLACEMENTS:
                                actual_key_found = image_filename_part_from_url
                            elif normalized_key_for_map in SVG_REPLACEMENTS:
                                actual_key_found = normalized_key_for_map

                            if actual_key_found:
                                base_svg_filename_from_map = SVG_REPLACEMENTS[actual_key_found]

                                chosen_local_svg_path = try_load_local_svg(
                                    base_svg_filename_from_map,
                                    image_folder_for_current_lang,
                                    current_lang_code,
                                    SVG_IMG_DIR
                                )

                                if chosen_local_svg_path:
                                    try:
                                        with open(chosen_local_svg_path, 'r', encoding='utf-8') as f_svg:
                                            svg_content = f_svg.read()
                                        # Create a new soup for the figure and replace its content with the SVG
                                        wrapper_figure = soup.new_tag('figure', **{'class': 'mw-halign-center'})
                                        wrapper_figure.append(BeautifulSoup(svg_content, 'html.parser'))
                                        content_html_parts.append(str(wrapper_figure))
                                        print(f"Replaced image {absolute_src} with local SVG: {chosen_local_svg_path} for lang {lang_key_for_debug_logging}")
                                    except Exception as e_svg:
                                        print(f"Error processing SVG file {chosen_local_svg_path}: {e_svg}. Using remote image {absolute_src}.", file=sys.stderr)
                                        image_src_set.add(absolute_src)
                                        img_tag['src'] = absolute_src
                                        content_html_parts.append(str(content_child))
                                else:
                                    # SVG not found through any fallback, use remote
                                    print(f"No suitable local SVG found for URL part '{image_filename_part_from_url}' (map key used: '{actual_key_found}', lang: '{current_lang_code}', folder: '{image_folder_for_current_lang}'). Using remote image {absolute_src} as fallback.", file=sys.stderr)
                                    image_src_set.add(absolute_src)
                                    img_tag['src'] = absolute_src
                                    content_html_parts.append(str(content_child))
                            else:
                                img_tag['src'] = absolute_src
                                image_src_set.add(absolute_src)
                                content_html_parts.append(str(content_child))
                        else:
                            content_html_parts.append(str(content_child))
                    elif content_child.name == 'img': # Handle images not in a div.center or figure
                        if content_child.has_attr('src'):
                            src = content_child['src']
                            absolute_src = src
                            if src.startswith('/w/'):
                                absolute_src = f"https://www.wittgensteinproject.org{src}"
                            
                            # image_filename_part = os.path.basename(absolute_src).split('?')[0] # Old way
                            basename = os.path.basename(absolute_src).split('?')[0]
                            match = re.match(r"\d+px-(.+)", basename)
                            if match:
                                image_filename_part_from_url = match.group(1)
                            else:
                                image_filename_part_from_url = basename

                            normalized_key_for_map = re.sub(r'(-?)(en|de|fr|it|es|pt)\.png$', '.png', image_filename_part_from_url, flags=re.IGNORECASE)

                            actual_key_found = None
                            if image_filename_part_from_url in SVG_REPLACEMENTS:
                                actual_key_found = image_filename_part_from_url
                            elif normalized_key_for_map in SVG_REPLACEMENTS:
                                actual_key_found = normalized_key_for_map
                                
                            if actual_key_found:
                                base_svg_filename_from_map = SVG_REPLACEMENTS[actual_key_found]
                                
                                chosen_local_svg_path = try_load_local_svg(
                                    base_svg_filename_from_map,
                                    image_folder_for_current_lang,
                                    current_lang_code,
                                    SVG_IMG_DIR
                                )

                                if chosen_local_svg_path:
                                    try:
                                        with open(chosen_local_svg_path, 'r', encoding='utf-8') as f_svg:
                                            svg_content = f_svg.read()
                                        # For a bare <img>, we directly append the SVG content (which becomes a string)
                                        # Or, parse it into a BeautifulSoup object if it needs to be a tag
                                        content_html_parts.append(BeautifulSoup(svg_content, 'html.parser').decode_contents())
                                        print(f"Replaced bare image {absolute_src} with local SVG: {chosen_local_svg_path} for lang {lang_key_for_debug_logging}")
                                    except Exception as e_svg:
                                        print(f"Error processing SVG file {chosen_local_svg_path}: {e_svg}. Using remote image {absolute_src}.", file=sys.stderr)
                                        image_src_set.add(absolute_src)
                                        content_child['src'] = absolute_src # Update the original img tag
                                        content_html_parts.append(str(content_child))
                                else:
                                    # SVG not found through any fallback, use remote
                                    print(f"No suitable local SVG found for URL part '{image_filename_part_from_url}' (map key used: '{actual_key_found}', lang: '{current_lang_code}', folder: '{image_folder_for_current_lang}'). Using remote image {absolute_src} as fallback.", file=sys.stderr)
                                    image_src_set.add(absolute_src)
                                    content_child['src'] = absolute_src
                                    content_html_parts.append(str(content_child))
                            else:
                                content_child['src'] = absolute_src
                                image_src_set.add(absolute_src)
                                content_html_parts.append(str(content_child))
                        else: # img tag without src
                            content_html_parts.append(str(content_child))
                    elif content_child.name == 'table': # Handle tables
                        # Preserve the entire table structure
                        table_html = str(content_child)
                        # Clean up any inline styles that might cause issues
                        table_html = re.sub(r'style="[^"]*"', '', table_html)
                        # Add our own classes for consistent styling
                        table_html = table_html.replace('class="wikitable', 'class="wikitable table table-bordered table-sm')
                        content_html_parts.append(table_html)
                    elif content_child.name == 'div' and 'tlp-flex-container' in content_child.get('class', []):
                        # Handle flex container with tables
                        flex_html = str(content_child)
                        # Clean up any inline styles
                        flex_html = re.sub(r'style="[^"]*"', '', flex_html)
                        # Add our own classes for consistent styling
                        flex_html = flex_html.replace('class="tlp-flex-container"', 'class="tlp-flex-container d-flex flex-wrap justify-content-center gap-4"')
                        flex_html = flex_html.replace('class="tlp-column"', 'class="tlp-column flex-grow-0"')
                        content_html_parts.append(flex_html)
                    else: # For other tags, get their text content
                        content_html_parts.append(content_child.get_text(separator=' ', strip=True))
                
                prop_text_html = ''.join(content_html_parts)
                # Further cleaning of combined text might be needed if mixing HTML and plain text results in awkward spacing
                prop_text_html = re.sub(r'\\s+', ' ', prop_text_html).strip()
                # Ensure spaces around preserved tags if they are mashed together with text
                prop_text_html = prop_text_html.replace('<div', ' <div').replace('</div>', '</div> ')
                prop_text_html = prop_text_html.replace('<img', ' <img').replace('/>', '/> ')
                prop_text_html = re.sub(r'\\s{2,}', ' ', prop_text_html).strip()

                propositions[prop_id] = prop_text_html # Store HTML content
                
                current_struct_node = {'Id': prop_id, 'Children': []}
                current_level_struct_list.append(current_struct_node)
                
                # Children of the current proposition are in a div like id="tlp-children-X.X"
                # which is a sibling to first_child_div, inside the main 'drawer'
                children_container_id = f"tlp-children-{raw_prop_id}" # Use raw_prop_id for finding children container
                children_container = drawer.find('div', id=children_container_id)
                if children_container:
                    process_drawers(children_container, current_struct_node['Children'])
            else:
                # This path might be taken if a tlp-drawer contains other tlp-drawers directly
                # without its own prop_id_span at the top level of its first_child_div.
                # An example could be the tlp-children-X.X divs when their parent tlp-drawer
                # didn't have an ID/text in its *immediate* first_child_div.
                # This is a fallback to ensure we don't miss nested structures.
                process_drawers(drawer, current_level_struct_list)


    process_drawers(main_content_container, structure_data_top_level)
    return propositions, structure_data_top_level

def main():
    parser = argparse.ArgumentParser(description='Parse Tractatus HTML and convert to JSON.')
    parser.add_argument('url', help='URL of the Tractatus page (tree-like view from wittgensteinproject.org)')
    parser.add_argument('language_key', help='Short unique key for this language (e.g., "germanOriginal", "englishOgden")')
    parser.add_argument('display_name', help='User-friendly display name for language switcher')
    parser.add_argument('--source_info', default='Source details not specified', help='Information about the source/translator')
    parser.add_argument('--is_structure_source', action='store_true', help='Use this URL as the canonical source for structure.json')

    args = parser.parse_args()

    print(f"Fetching and parsing: {args.url}")
    soup = get_soup(args.url)
    if not soup:
        print("Failed to retrieve or parse HTML.", file=sys.stderr)
        return

    # Determine the image folder for the current language directly from its LanguageKey.
    # The script will look for SVGs in a subfolder named after this key (e.g., "germanOriginal")
    # within SVG_IMG_DIR, before falling back to the root of SVG_IMG_DIR.
    current_lang_image_folder = args.language_key

    # Get current language code
    current_lang_code = get_lang_code(args.language_key)

    # Initialize a set to store all unique image sources found across runs
    # For now, let's assume it's overwritten per run, or you manage accumulation if running for all languages in one go.
    found_image_sources_set = set()

    propositions, structure_data = parse_tlp_page(soup, args.language_key, found_image_sources_set, current_lang_image_folder, current_lang_code)

    if not propositions and not structure_data:
         print(f"No propositions or structure extracted for {args.language_key}. Exiting.", file=sys.stderr)
         return
    elif not propositions:
        print(f"Warning: No proposition texts extracted for {args.language_key}, but structure might have been found.", file=sys.stderr)
    elif not structure_data and args.is_structure_source:
        print(f"Warning: No structure data extracted for {args.language_key}, though it was designated as structure source.", file=sys.stderr)


    if not os.path.exists(OUTPUT_DIR):
        os.makedirs(OUTPUT_DIR)

    # Save the language-specific text data
    if propositions:
        lang_file_path = os.path.join(OUTPUT_DIR, f"{args.language_key}.json")
        with open(lang_file_path, 'w', encoding='utf-8') as f:
            json.dump(propositions, f, ensure_ascii=False, indent=2)
        print(f"Saved proposition texts to: {lang_file_path} ({len(propositions)} texts)")
    else:
        print(f"No proposition texts to save for {args.language_key}.")


    # If this is the structure source, save structure.json
    if args.is_structure_source:
        if structure_data:
            # --- BEGIN ADD PREFACE TO STRUCTURE ---
            if "Preface" in propositions: # Check if Preface was extracted
                preface_node = {"Id": "Preface", "Children": []}
                # Ensure structure_data is a list (it should be)
                if isinstance(structure_data, list):
                    structure_data.insert(0, preface_node)
                    print("Added Preface node to the beginning of structure_data.")
                else:
                    print("Warning: structure_data is not a list, cannot insert Preface node.", file=sys.stderr)
            else:
                print("Preface not found in propositions, not adding to structure_data.")
            # --- END ADD PREFACE TO STRUCTURE ---
            structure_file_path = os.path.join(OUTPUT_DIR, STRUCTURE_FILE_NAME)
            with open(structure_file_path, 'w', encoding='utf-8') as f:
                json.dump(structure_data, f, ensure_ascii=False, indent=2)
            print(f"Saved structure to: {structure_file_path}")
        else:
            print(f"No structure data to save, though {args.language_key} was designated structure source.")


    # Update language-info.json
    language_info_path = os.path.join(OUTPUT_DIR, LANGUAGE_INFO_FILE_NAME)
    lang_info = []
    if os.path.exists(language_info_path):
        try:
            with open(language_info_path, 'r', encoding='utf-8') as f:
                lang_info = json.load(f)
        except json.JSONDecodeError:
            print(f"Warning: Could not decode existing {LANGUAGE_INFO_FILE_NAME}. Starting fresh.", file=sys.stderr)
            lang_info = []

    lang_info = [entry for entry in lang_info if entry.get('LanguageKey') != args.language_key]
    
    new_entry = {
        "LanguageKey": args.language_key,
        "DisplayName": args.display_name,
        "SourceInfo": args.source_info,
        "DataFile": f"{args.language_key}.json"
    }
    lang_info.append(new_entry)

    with open(language_info_path, 'w', encoding='utf-8') as f:
        json.dump(lang_info, f, ensure_ascii=False, indent=2)
    print(f"Updated language info at: {language_info_path}")

    # Save the list of found image sources
    if found_image_sources_set:
        found_images_path = os.path.join(OUTPUT_DIR, FOUND_IMAGES_FILE_NAME)
        # Load existing images if file exists, to append and keep unique
        existing_images = set()
        if os.path.exists(found_images_path):
            try:
                with open(found_images_path, 'r', encoding='utf-8') as f:
                    data = json.load(f)
                    if isinstance(data, list):
                        existing_images.update(data)
            except json.JSONDecodeError:
                print(f"Warning: Could not decode existing {FOUND_IMAGES_FILE_NAME}. Starting fresh for image list.", file=sys.stderr)
        
        all_images_to_save = list(existing_images.union(found_image_sources_set))
        all_images_to_save.sort() # Optional: sort for consistent output

        with open(found_images_path, 'w', encoding='utf-8') as f:
            json.dump(all_images_to_save, f, ensure_ascii=False, indent=2)
        print(f"Saved/Updated list of found image sources to: {found_images_path} ({len(all_images_to_save)} unique images total)")
    else:
        print("No image sources found in this run.")


if __name__ == '__main__':
    main()