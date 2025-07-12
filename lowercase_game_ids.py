import re
import os
import argparse
import shutil

def process_file(file_path):
    """
    Reads a file line by line, converts the value of any 'GameID' property to lowercase,
    and overwrites the original file with the changes.
    """
    if not os.path.exists(file_path):
        print(f"Error: File not found at '{file_path}'")
        return

    temp_file_path = file_path + '.tmp'
    lines_changed = 0

    try:
        with open(file_path, 'r', encoding='utf-8') as infile, open(temp_file_path, 'w', encoding='utf-8') as outfile:
            for line in infile:
                # Regex to find 'GameID = "Value"' and capture 'Value'
                # It handles potential whitespace variations around the equals sign.
                pattern = r'(GameID\s*=\s*")([^"]+)(")'

                # The replacement function that lowercases the captured GameID
                def repl(match):
                    # match.group(1) is 'GameID = "'
                    # match.group(2) is the actual ID to be lowercased
                    # match.group(3) is the closing '"'
                    return match.group(1) + match.group(2).lower() + match.group(3)

                new_line = re.sub(pattern, repl, line)
                if new_line != line:
                    lines_changed += 1
                outfile.write(new_line)
        
        # Safely replace the original file with the temporary one
        shutil.move(temp_file_path, file_path)
        print(f"Processing complete. Changed {lines_changed} lines in '{os.path.basename(file_path)}'.")

    except Exception as e:
        print(f"An error occurred: {e}")
        # Clean up the temporary file if an error occurs
        if os.path.exists(temp_file_path):
            os.remove(temp_file_path)

if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Convert GameID values in C# initializer files to lowercase."
    )
    parser.add_argument(
        "file_path", 
        help="The path to the C# file to process (e.g., Data/Initializers/GameInitializer.cs)."
    )
    args = parser.parse_args()
    
    process_file(args.file_path) 