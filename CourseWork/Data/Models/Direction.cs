using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CourseWork.Data.Models
{
    
    public class Direction
    {
        public string Id { get; set; }
        
        public string NameOfDirection { get; set; }
        public string Description { get; set; }
       
        public List<Service> Services { get; set; }
    }
}
