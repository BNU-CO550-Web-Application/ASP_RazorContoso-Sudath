﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_RazorContoso.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [DisplayName("Last Name"), Required, StringLength(50)]
        public string LastName { get; set; }
        
        [DisplayName("First Name"), Required, StringLength(50)]
        public string FirstMidName { get; set; }
        
        [DisplayName("Enrollment Date"), Required, DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        //Navigation property
        public ICollection<Enrollment> Enrollments { get; set; }

        [DisplayName("Full Name")]
        public string FullName()
        {
            return FirstMidName + "" + LastName;    
        }
        
    }
}
