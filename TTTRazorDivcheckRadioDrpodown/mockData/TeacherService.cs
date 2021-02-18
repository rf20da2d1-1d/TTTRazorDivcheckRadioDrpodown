using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTTRazorDivcheckRadioDrpodown.model;

namespace TTTRazorDivcheckRadioDrpodown.mockData
{
    public class TeacherService : ITeacherService
    {
        private List<Teacher> teachers;

        public TeacherService()
        {
            teachers = new List<Teacher>()
            {
                new Teacher("Peter", true, "Roskilde"){Courses = { "SWC1", "SWC2", "TEK"}},
                new Teacher("Jakob", true, "Roskilde"){Courses = { "SWD1", "SWD2"}},
                new Teacher("Vibeke", false, "Roskilde"){Courses = { "SWD1", "SWD2", "SYM", "VF"}},
                new Teacher("Carsten", true, "Næstved"){Courses = { "TEK", "VF"}}
            };
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(teachers);
            }
        }

        

        public void Add(Teacher item)
        {
            teachers.Add(item);
        }

        public void Clear()
        {
            teachers.Clear();
        }

        public Teacher Find(Predicate<Teacher> match)
        {
            return teachers.Find(match);
        }

        public bool Remove(Teacher item)
        {
            return teachers.Remove(item);
        }



    }
}
