using System.Collections.Generic;
using CourseWork.Reading;

namespace CourseWork.FileExtension
{
    public class FileExtension
    {
        public List<Data.Models.Direction> LoadingServices(string path)
        {
            IReader reader;
            var list = new List<Data.Models.Direction>();
            var maStrings = path.Split('.');
            if (maStrings[1] == "txt")
            {
               reader = new TxtReader();
               list =  reader.ReadServices(path);
            }
            if (maStrings[1] == "csv")
            {
                reader = new CsvReader();
               list = reader.ReadServices(path);
            }
            if (maStrings[1] == "json")
            {
                reader = new JsonReader();
                list = reader.ReadServices(path);
            }
            return list;
        }

        //public List<Data.Models.Direction> LoadingClients(string path)
        //{
           
        //}
    }
}