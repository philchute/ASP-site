# tractatus-json-structure-to-json-template.py
#
# README:
# This script generates a template JSON file for creating new translations or commentary
# for the Tractatus Logico-Philosophicus.
#
# Purpose:
# To extract all unique proposition IDs from 'wwwroot/data/structure.json' and create
# a new JSON file where each ID is a key with an empty string as its value. This
# provides a starting point for adding text for each proposition.
#
# How to use:
# 1. Ensure 'wwwroot/data/structure.json' exists and is correctly formatted.
# 2. Run this script from the workspace root: python tractatus-json-structure-to-json-template.py
# 3. The script will create 'wwwroot/data/blank_translation_template.json'.
#
# Next Steps:
# 1. Copy 'blank_translation_template.json' to a new file in the 'wwwroot/data/'
#    directory (e.g., 'my_new_translation.json', 'modern_text.json', 'notes.json').
# 2. Edit the new JSON file to add your translation text or notes for each proposition ID.
# 3. Update 'wwwroot/data/language-info.json' to include metadata for your new
#    translation, pointing the 'DataFile' property to your new JSON file name.
import json
import os

# Define the base path for data files relative to the workspace root
# This script assumes it's run from the workspace root.
DATA_DIR = os.path.join("wwwroot", "data")
STRUCTURE_FILE = os.path.join(DATA_DIR, "structure.json")
# Output file for the blank template
BLANK_TEMPLATE_OUTPUT_FILE = os.path.join(DATA_DIR, "blank_translation_template.json")

def get_all_proposition_ids(filepath):
    """
    Reads the structure.json file and recursively extracts all proposition IDs.
    """
    all_ids = set()
    try:
        with open(filepath, 'r', encoding='utf-8') as f:
            data = json.load(f)
    except FileNotFoundError:
        print(f"Error: File not found - {filepath}")
        print(f"Current working directory: {os.getcwd()}")
        return []
    except json.JSONDecodeError:
        print(f"Error: Could not decode JSON from - {filepath}")
        return []

    def recursive_extract(nodes):
        for node in nodes:
            if "Id" in node:
                all_ids.add(node["Id"])
            if "Children" in node and isinstance(node["Children"], list):
                recursive_extract(node["Children"])
    
    recursive_extract(data)
    return sorted(list(all_ids))

def generate_blank_template_file():
    """
    Generates a blank JSON template file populated with all proposition IDs
    from structure.json and empty string values.
    """
    if not os.path.exists(DATA_DIR):
        print(f"Data directory {DATA_DIR} does not exist. Creating it.")
        os.makedirs(DATA_DIR)
    elif not os.path.isdir(DATA_DIR):
        print(f"Error: {DATA_DIR} exists but is not a directory.")
        return
        
    proposition_ids = get_all_proposition_ids(STRUCTURE_FILE)
    
    if not proposition_ids:
        print("No proposition IDs found or error reading structure file. Aborting template file generation.")
        return

    print(f"Found {len(proposition_ids)} proposition IDs from {STRUCTURE_FILE}.")

    blank_data = {prop_id: "" for prop_id in proposition_ids}

    try:
        with open(BLANK_TEMPLATE_OUTPUT_FILE, 'w', encoding='utf-8') as f:
            json.dump(blank_data, f, indent=2, ensure_ascii=False)
        print(f"Successfully generated blank template: {BLANK_TEMPLATE_OUTPUT_FILE}")
        print(f"You can now copy this file to create new translation/notes files (e.g., modern_text.json, notes.json).")
    except IOError as e:
        print(f"Error writing {BLANK_TEMPLATE_OUTPUT_FILE}: {e}")

if __name__ == "__main__":
    print(f"Starting generation of blank Tractatus data template ({os.path.basename(BLANK_TEMPLATE_OUTPUT_FILE)})...")
    generate_blank_template_file()
    print("Script finished.") 