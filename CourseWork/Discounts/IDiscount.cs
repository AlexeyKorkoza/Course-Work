using System.Collections.Generic;
using CourseWork.Data.Models;

namespace CourseWork.Discounts
{
    public interface IDiscount
    {
       List<Discount> ReadDiscountses();
       void Delete(int code);
       void Add(int code, int size);
       void Update(string newcode, int code, int size);
       bool Check(int code);
       void Write(List<Discount> discounts);
    }
}
