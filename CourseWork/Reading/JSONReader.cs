using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace CourseWork.Reading
{
    public class JsonReader:IReader
    {
        public List<Data.Models.Direction> ReadServices(string path)
        {
            var json = File.ReadAllText(path);
            var dir = JsonConvert.DeserializeObject<List<Data.Models.Direction>>(json);
            return dir;
        }
    }
}
