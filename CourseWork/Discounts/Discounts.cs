using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using CourseWork.Data.Models;

namespace CourseWork.Discounts
{
    public class Discounts : IDiscount
    {
        private readonly string _path = ConfigurationManager.AppSettings["DiscountsPath"];
        public List<Discount> ReadDiscountses()
        {
            var list = new List<Discount>();
            var sr = new StreamReader(_path);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var array = line.Split(',', '\t');
                    var discounts = new Discount
                    {
                        Code = Convert.ToInt32(array[0]),
                        Size = Convert.ToInt32(array[1])
                    };
                    list.Add(discounts);
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

        public void Delete(int code)
        {
            var list = ReadDiscountses();
            var writer = new StreamWriter(_path, false);
            foreach (var t in list.Where(t => t.Code != code))
            {
                writer.WriteLine(t.Code + "," + t.Size);
            }
            writer.Close();
        }

        public void Add(int code, int size)
        {
            var writer = new StreamWriter(_path, true);
            writer.WriteLine(code + "," + size);
            writer.Close();
        }

        public void Update(string newcode, int code, int size)
        {
            var list = ReadDiscountses();
            var writer = new StreamWriter(_path, false);
            if (newcode.Length == 0)
            {
                for (var k = 0; k < list.Count; k++)
                {
                    if (list[k].Code == code)
                    {
                        writer.WriteLine(code + "," + size);
                    }
                    else
                    {
                        writer.WriteLine(list[k].Code + "," + list[k].Size);
                    }
                }
            }
            else
            {
                for (var k = 0; k < list.Count; k++)
                {
                    if (list[k].Code == code)
                    {
                        writer.WriteLine(newcode + "," + size);
                    }
                    else
                    {
                        writer.WriteLine(list[k].Code + "," + list[k].Size);
                    }
                }
            }
            writer.Close();
        }

        public bool Check(int code)
        {
            var list = ReadDiscountses();
            return list.All(t => t.Code != code);
        }

        public void Write(List<Discount> discounts)
        {
            var writer = new StreamWriter(_path, true);
            for (var k = 0; k < discounts.Count; k++)
            {
                if (Check(discounts[k].Code))
                {
                    writer.WriteLine(discounts[k].Code + "," + discounts[k].Size);
                }
            }
            writer.Close();
        } 
    }
}
