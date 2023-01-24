using online_courses.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_courses.Models
{
    public class Category
    {
        public int Id { get; set; }

        public GradeCategory Grade { get; set; }

        public SemesterCategory Semester { get; set; }

        //Relationships
        public List<Course> Courses { get; set; }

        //EducationalStage
        public int EducationalStageId { get; set; }
        [ForeignKey("EducationalStageId")]
        public EducationalStage EducationalStage { get; set; }


        //Subject
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subjectt { get; set; }

    }
}
