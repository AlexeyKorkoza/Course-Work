using System;
using System.Collections.Generic;
using System.IO;
using CourseWork.Data.Models;

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

        public List<Data.Models.Client> ReadClients(string path)
        {
            var list = new List<Data.Models.Client>();
            var sr = new StreamReader(path);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var array = line.Split(',', '\t');
                    var services = new Data.Models.Client
                    {
                        Lastname = array[0],
                        Name = array[1],
                        MiddleName = array[2],
                        Date = array[3],
                        AgeCategory = array[4],
                        Decor = array[5],
                        Payment = array[6],
                        Visit = array[7],
                        Directions = new List<Data.Models.Direction>()
                        {
                         new Data.Models.Direction()
                        {
                        NameOfDirection = array[8]
                        }
                        },
                        Services = new List<Data.Models.Service>()
                        {
                            new Data.Models.Service()
                            {
                                NameService = array[9],
                                Duration = int.Parse(array[10]),
                                Cost = int.Parse(array[11])
                            }
                        },
                        Discounts = new List<Discount>()
                        {
                            new Discount()
                            {
                                Code = Convert.ToInt32(array[12]),
                                Size = Convert.ToInt32(array[13])
                            }
                        }
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