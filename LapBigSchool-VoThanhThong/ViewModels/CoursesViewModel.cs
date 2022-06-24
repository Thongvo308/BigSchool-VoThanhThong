using LapBigSchool_VoThanhThong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LapBigSchool_VoThanhThong.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}