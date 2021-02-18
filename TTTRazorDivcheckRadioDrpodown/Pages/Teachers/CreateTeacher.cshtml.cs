using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTRazorDivcheckRadioDrpodown.mockData;
using TTTRazorDivcheckRadioDrpodown.model;

namespace TTTRazorDivcheckRadioDrpodown.Pages.Teachers
{
    public class CreateTeacherModel : PageModel
    {

        private ITeacherService _teacherService;

        public CreateTeacherModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
            _locations = LocationService.Locations;
            _courses = CourseServices.Courses;
            //_teacher = new Teacher();

        }

        /*
         * Helper to get IsMale, workingLocation
         */
        [BindProperty]
        public string Gender { get; set; }
        public string[] Genders = new[] { "Male", "Female"};
        
        [BindProperty]
        public string Place { get; set; }

        [BindProperty]
        public List<String> AreChecked{ get; set; }


        [BindProperty]
        public String Text { get; set; }


        private Teacher _teacher;

        [BindProperty]
        public Teacher Teacher
        {
            get => _teacher;
            set => _teacher = value;
        }

        private readonly List<String> _locations;

        private readonly List<String> _courses;

        public List<string> Locations => _locations;

        public List<string> Courses => _courses;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _teacher.IsMale = Gender == "Male";
            _teacher.WorkingLocation = Place; //Request.Form["locations"];
            _teacher.Courses.AddRange(AreChecked); 

            _teacherService.Add(_teacher);

            return RedirectToPage("Index");
        }
    }
}
