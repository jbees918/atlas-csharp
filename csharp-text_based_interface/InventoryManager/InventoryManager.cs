using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryManager
{
    public class JSONStorage
    {
        const string storagePath = "../storage/inventory_manager.json";
        public static JSONStorage instance = new JSONStorage();
        Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();
        public static string[] classes = new string[] { "User", "Item", "Inventory" };

        public void Clear()
        {
            objects.Clear();
        }

        public void GetItem(string ClassName, string id)
        {
            string key = String.Format("{0}.{1}", ClassName, id);
            foreach( KeyValuePair<string, BaseClass> kvp in objects)
            {
                if (kvp.Key.ToLower() == key)
                    return kvp.Value;
            }
            return null;
        }

        public void DeleteItem(string ClassName, string id)
        {
            string key = String.Format("{0}.{1}", ClassName, id);
            if (objects.ContainsKey(key))
                objects.Remove(key);
            else
                Console.WriteLine("Error: Object not found.");
        }

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

        public void New(BaseClass obj)
        {
            string key = String.Format("{0}.{1}", obj.GetType().Name, obj.id);
            objects.Add(key, obj);
        }

        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        private void PreparePath()
        {
            string path = Path.GetDirectoryName(storagePath);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void BuildFromJson(string jsonData, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
