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
    }
}
