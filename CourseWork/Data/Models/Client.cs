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
        public Direction[] Directions { get; set; }
        public Service[] Services { get; set; }
        public Discount[] Discounts { get; set; }
        }
}
