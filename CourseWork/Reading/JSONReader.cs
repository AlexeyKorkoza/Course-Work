using System.Collections.Generic;
using System.IO;
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
            var list = new List<Data.Models.Client>();
            return list;
        }
    }
}
