using System.Collections.Generic;

namespace CourseWork.Reading
{
    public interface IReader
    {
        List<Data.Models.Direction> ReadServices(string path);
        List<Data.Models.Client> ReadClients(string path);
        List<Data.Models.Direction> ReadDirections(string path);
    }
}