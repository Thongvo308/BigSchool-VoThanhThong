using LapBigSchool_VoThanhThong.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace LapBigSchool_VoThanhThong.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        string day = "dd/M/yyyy";
        string tim = "HH:mm";
        public DateTime GetDateTime()
        {
            return DateTime.ParseExact(string.Format("{0} {1}", Date, Time), string.Format("{0} {1}", day, tim), CultureInfo.CurrentCulture);
        }
    }
}
