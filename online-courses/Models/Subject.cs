using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace online_courses.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public string Outcome { get; set; }
        //Relationships
        public List<Category> Categories { get; set; }
    }
}
