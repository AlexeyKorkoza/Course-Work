using System.Collections.Generic;
using CourseWork.Data.Models;
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

        public List<Data.Models.Client> LoadingClients(string path)
        {
            IReader reader;
            var list = new List<Data.Models.Client>();
            var maStrings = path.Split('.');
            if (maStrings[1] == "csv")
            {
                reader = new CsvReader();
                list = reader.ReadClients(path);
            }
            if (maStrings[1] == "json")
            {
                reader = new JsonReader();
                list = reader.ReadClients(path);
            }
            return list;
        }

        public List<Data.Models.Direction> LoadingDirections(string path)
        {
            IReader reader;
            var list = new List<Data.Models.Direction>();
            var maStrings = path.Split('.');
            if (maStrings[1] == "csv")
            {
                reader = new CsvReader();
                list = reader.ReadDirections(path);
            }
            if (maStrings[1] == "json")
            {
                reader = new JsonReader();
                list = reader.ReadDirections(path);
            }
            return list;
        }

        public List<Discount> LoadingDiscountses(string path)
        {
            IReader reader;
            var list = new List<Discount>();
            var maStrings = path.Split('.');
            if (maStrings[1] == "csv")
            {
                reader = new CsvReader();
                list = reader.ReadDiscountses(path);
            }
            if (maStrings[1] == "json")
            {
                reader = new JsonReader();
                list = reader.ReadDiscountses(path);
            }
            return list;
        }
    }
}