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
    public class IndexModel : PageModel
    {
        private ITeacherService _teacherService;

        private List<Teacher> _teachers;

        public List<Teacher> Teachers => _teachers;

        public IndexModel(ITeacherService teacherService)
        {
            this._teacherService = teacherService;

            
        }

        public void OnGet()
        {
            _teachers = _teacherService.Teachers;
        }
    }
}
