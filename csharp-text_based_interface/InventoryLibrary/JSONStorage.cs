using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using System.IO;

namespace InventoryLibrary
{
    /// <summary>Class JSON Storage </summary>
    public class JSONStorage
    {
        const string storagePath = "../storage/inventory_manager.json";
        public static JSONStorage instance = new JSONStorage();
        Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();
        public static string[] classes = new string[] { "User", "Item", "Inventory" };

        /// <summary> Returns all objects </summary>
        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        /// <summary> Add new obj. </summary>
        public void New(BaseClass obj)
        {
            string key = String.Format("{0}.{1}", obj.GetType().Name, obj.id);
            objects.Add(key, obj);
        }

        /// <summary> Save all objects to file </summary>
        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            try
            {
                PreparePath();
                File.WriteAllText(storagePath, jsonString);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to save to file.");
                Console.ResetColor();
                Console.WriteLine(e);
            }
        }

        /// <summary> Delete obj from memz </summary>
        public void DeleteItem(string ClassName, string id)
        {
            string key = String.Format("{0}.{1}", ClassName, id);
            if (objects.ContainsKey(key))
                objects.Remove(key);
            else
                Console.WriteLine("Error: Object not found.");
        }

        /// <summary> Loads obj's from file </summary>
        public void Load()
        {
            string jsonString = "";
            try
            {
                PreparePath();
                jsonString = File.ReadAllText(storagePath);
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to load from file.");
                Console.ResetColor();
                return;
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to load from file due to unknown issue.");
                Console.ResetColor();
                return;
            }
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }

        /// <summary> Retrieve an object from memry </summary>
        public BaseClass GetItem(string ClassName, string id)
        {
            string key = String.Format("{0}.{1}", ClassName, id);
            foreach( KeyValuePair<string, BaseClass> kvp in objects)
            {
                if (kvp.Key.ToLower() == key)
                    return kvp.Value;
            }
            return null;
        }

        private void PreparePath()
        {
            string path = Path.GetDirectoryName(storagePath);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private string BuildJSONDict()
        {
            List<User> users = new List<User>();
            List<Item> items = new List<Item>();
            List<Inventory> inventories = new List<Inventory>();
            foreach (KeyValuePair<string, BaseClass> kvp in objects)
            {
                string type = kvp.Key.Split('.')[0].ToLower();
                if (type == "user")
                    users.Add(kvp.Value as User);
                else if (type == "item")
                    items.Add(kvp.Value as Item);
                else if (type == "inventory")
                    inventories.Add(kvp.Value as Inventory);
                else
                    Console.WriteLine("Error: Unknown type.");
            }
            string results = JsonSerializer.Serialize(users) + '\n';
            results += JsonSerializer.Serialize(items) + '\n';
            results += JsonSerializer.Serialize(inventories);
            return results;
        }

        private void BuildFromJson(string jsonData, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
