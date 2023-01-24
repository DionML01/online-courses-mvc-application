using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;

namespace online_courses.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        public string Duration { get; set; } //1 month
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Relationships
        public List<Course> Courses { get; set; }
    }
}
