namespace CourseWork.Models
{
    public class Direction
    {
        public string Id { get; set; }
        public string NameOfDirection { get; set; }
        public string Description { get; set; }
        public Service[] Services { get; set; }
    }
}
