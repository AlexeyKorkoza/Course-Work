using System.Collections.Generic;
using CourseWork.Data.Models;

namespace CourseWork.Reading
{
    public interface IReader
    {
        List<Data.Models.Direction> ReadServices(string path);
        List<Data.Models.Client> ReadClients(string path);
        List<Data.Models.Direction> ReadDirections(string path);
        List<Discount> ReadDiscountses(string path);
    }
}