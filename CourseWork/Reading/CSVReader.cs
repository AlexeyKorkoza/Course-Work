using System;
using System.Collections.Generic;
using System.IO;

namespace CourseWork.Reading
{
    public class CsvReader : IReader
    {
        public List<Data.Models.Direction> ReadServices(string path)
        {
            var list = new List<Data.Models.Direction>();
            var sr = new StreamReader(path);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var array = line.Split(',', '\t');
                    var services = new Data.Models.Direction
                    {
                        NameOfDirection = array[0],
                        Services = new List<Data.Models.Service>()
                        {
                            new Data.Models.Service()
                            {
                                NameService = array[1],
                                Duration = int.Parse(array[2]),
                                Cost = int.Parse(array[3])
                            }
                        },
                    };
                    list.Add(services);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }
            return list;
        }
    }
}