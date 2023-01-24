using online_courses.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace online_courses.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string PictureUrl { get; set; }

        public string Short_description { get; set; }

        public double Price { get; set; }

        public LanguageCategory Language { get; set; }


        //Relationships


        //Schedule
        public int ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public Schedule Schedule { get; set; }

        //Category
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }
}
