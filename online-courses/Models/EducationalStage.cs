
using OnlineCourses.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace online_courses.Models
{
    public class EducationalStage
    {
        [Key]
        public int Id { get; set; }
        public StageNameCategory StageName { get; set; } 
        public string Description { get; set; }
        //Relationships
        public List<Category> Categories { get; set; }
    }
}
