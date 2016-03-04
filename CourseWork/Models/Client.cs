namespace CourseWork.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Date { get; set; }
        public string AgeCategory { get; set; }
        public Direction Direction { get; set; }
        public Discount Discount { get; set;}
    }
}
