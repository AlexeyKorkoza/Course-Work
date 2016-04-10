using System.Collections.Generic;
using System.IO;
using CourseWork.Data.Models;
using Newtonsoft.Json;

namespace CourseWork.Reading
{
    public class JsonReader : IReader
    {
        public List<Data.Models.Direction> ReadServices(string path)
        {
            var json = File.ReadAllText(path);
            var dir = JsonConvert.DeserializeObject<List<Data.Models.Direction>>(json);
            return dir;
        }

        public List<Data.Models.Client> ReadClients(string path)
        {
            var json = File.ReadAllText(path);
            var client = JsonConvert.DeserializeObject<List<Data.Models.Client>>(json);
            return client;
        }

        public List<Data.Models.Direction> ReadDirections(string path)
        {
            var json = File.ReadAllText(path);
            var dir = JsonConvert.DeserializeObject<List<Data.Models.Direction>>(json);
            return dir;
        }

        public List<Discount> ReadDiscountses(string path)
        {
            var json = File.ReadAllText(path);
            var discountses = JsonConvert.DeserializeObject<List<Discount>>(json);
            return discountses;
        }
    }
}
