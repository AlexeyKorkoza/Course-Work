﻿using System.Collections.Generic;

namespace CourseWork.Reading
{
    public interface IReader
    {
        List<Data.Models.Direction> ReadServices(string path);
    }
}