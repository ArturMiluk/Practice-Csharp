using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentDiary.Services
{
    public class JsonService
    {
        public async Task SaveAsync<T>(string fileName, T data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            await File.WriteAllTextAsync(fileName, json);
        }

        public async Task<T?> LoadAsync<T>(string fileName)
        {
            if (!File.Exists(fileName))
                return default;

            var json = await File.ReadAllTextAsync(fileName);

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}