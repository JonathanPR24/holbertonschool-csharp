using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        // Dictionary to store objects with keys formatted as "<ClassName>.<id>"
        private Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

        // Add a new object to the dictionary
        public void New(dynamic obj)
        {
            try
            {
                string key = $"{obj.GetType().Name}.{obj.id}";
                if (!objects.ContainsKey(key))
                    objects.Add(key, obj);
                else
                    Console.WriteLine($"Object with key '{key}' already exists.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"An error occurred while adding the object: {ex.Message}");
            }
        }

        // Return the entire dictionary of objects
        public Dictionary<string, dynamic> All()
        {
            return objects;
        }

        // Serialize objects to JSON and save to file
        public void Save()
        {
            try
            {
                string directory = "storage";
                string fileName = Path.Combine(directory, "inventory_manager.json");

                // Create storage directory if it doesn't exist
                Directory.CreateDirectory(directory);

                // Serialize objects to JSON with indented formatting
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(objects, options);

                // Write JSON to file
                File.WriteAllText(fileName, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the objects: {ex.Message}");
            }
        }

        // Deserialize JSON file to objects
        public void Load()
        {
            try
            {
                string directory = "storage";
                string fileName = Path.Combine(directory, "inventory_manager.json");

                // Deserialize JSON from file
                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    objects = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
                }
                else
                {
                    Console.WriteLine("JSON file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the objects: {ex.Message}");
            }
        }
    }
}
