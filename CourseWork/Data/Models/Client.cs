using System.Collections.Generic;

namespace CourseWork.Data.Models
{
    public class Client
    {
        public string Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Date { get; set; }
        public string AgeCategory { get; set; }
        public string Decor { get; set; }
        public string Payment { get; set; }
        public string Visit { get; set; }
        public List<Direction> Directions { get; set; }
        public List<Service> Services { get; set; }
        public List<Discount> Discounts { get; set; }
     }
}
