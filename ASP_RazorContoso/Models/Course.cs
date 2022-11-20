using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_RazorContoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Navigation Property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
