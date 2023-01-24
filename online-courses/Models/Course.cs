using online_courses.Data.Enums;
using System.ComponentModel.DataAnnotations;
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


    }
}
