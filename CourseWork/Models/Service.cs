namespace CourseWork.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public int Cost { get; set; }
        public Subscription Subscription { get; set; }
    }
}
