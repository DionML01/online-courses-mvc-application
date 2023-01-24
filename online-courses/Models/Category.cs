using online_courses.Data.Enums;

namespace online_courses.Models
{
    public class Category
    {
        public int Id { get; set; }

        public GradeCategory Grade { get; set; }

        public SemesterCategory Semester { get; set; }

    }
}
