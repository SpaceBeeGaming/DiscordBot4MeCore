using System.IO;

using Newtonsoft.Json;

namespace DiscordBot4MeCore.Storage.Implementations
{
    public class JsonStorage : IDataStorage
    {
        public T RestoreObject<T>(string key)
        {
            string json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void StoreObject(object obj, string key)
        {
            string file = $"{key}.json";
            Directory.CreateDirectory(Path.GetDirectoryName(file));
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(file, json);
        }
    }
}
