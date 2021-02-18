using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTTRazorDivcheckRadioDrpodown.mockData
{
    public static class CourseServices
    {
        private static List<string> courses = new List<string>()
        {
            "SWC1", "SWC2", "SWD1", "SWD2", "TEK", "SYM", "PROG", "VF"
        };

        public static List<string> Courses => courses;
    }
}
