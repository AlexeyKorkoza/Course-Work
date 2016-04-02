using System.Collections.Generic;

namespace CourseWork.Reading
{
    public interface IReading
    {
        List<Data.Models.Direction> ReadServices(string path);
    }
}