namespace CourseWork.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public string NameOfService { get; set; }
        public string Description { get; set; }
        public Service Service { get; set; }
    }
}
