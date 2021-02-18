using System;
using System.Collections.Generic;
using TTTRazorDivcheckRadioDrpodown.model;

namespace TTTRazorDivcheckRadioDrpodown.mockData
{
    public interface ITeacherService
    {
        List<Teacher> Teachers { get; }
        void Add(Teacher item);
        void Clear();
        Teacher Find(Predicate<Teacher> match);
        bool Remove(Teacher item);
    }
}