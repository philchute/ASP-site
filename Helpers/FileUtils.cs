using Newtonsoft.Json;
using System.Text;

namespace ASP_site.Helpers
{
    public static class FileUtils
    {
        public static async Task<T> ReadJsonFileAsync<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"JSON file not found at path: {filePath}");
            }

            var jsonContent = await File.ReadAllTextAsync(filePath, Encoding.UTF8);
            var data = JsonConvert.DeserializeObject<T>(jsonContent);

            if (data == null)
            {
                throw new InvalidOperationException($"Failed to deserialize JSON content from file: {filePath}");
            }

            return data;
        }
    }
} 