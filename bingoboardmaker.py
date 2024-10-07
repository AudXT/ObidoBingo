import csv
import json

def csv_to_json(csv_file, json_file):
    data_list = []

    with open(csv_file, mode='r', newline='') as file:
        reader = csv.reader(file)
        for row in reader:
            if len(row) < 2:
                continue  # Skip rows that don't have at least two columns
            if row[2] == "No" and row[D] > 0:
                continue;
            data_list.append({
                "category": row[0],
                "name": row [0] + ": " + row[1]
            })

    with open(json_file, mode='w') as file:
        json.dump(data_list, file, indent=4)

    print(f"JSON data has been written to {json_file}")

csv_file = 'ideas.csv'
json_file = 'output.json'
csv_to_json(csv_file, json_file)
