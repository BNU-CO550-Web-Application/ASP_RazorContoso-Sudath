using System;
using System.Collections.Generic;
using System.Linq;
using ASP_RazorContoso.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ASP_RazorContoso.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var nawagamuwage = new Student
            {
                FirstMidName = "Sudath",
                LastName = "Nawagamuwage",
                EnrollmentDate = DateTime.Parse("2021-09-10")
            };

            var adams = new Student
            {
                FirstMidName = "James",
                LastName = "Adams",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var fast = new Student
            {
                FirstMidName = "Andrew",
                LastName = "Fast",
                EnrollmentDate = DateTime.Parse("2019-09-01")
            };

            var king = new Student
            {
                FirstMidName = "Emma",
                LastName = "King",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var brooks = new Student
            {
                FirstMidName = "Elizabeth",
                LastName = "Brooks",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var miles = new Student
            {
                FirstMidName = "Tania",
                LastName = "Miles",
                EnrollmentDate = DateTime.Parse("2017-09-01")
            };

            var woodward = new Student
            {
                FirstMidName = "Ruth",
                LastName = "Woodward",
                EnrollmentDate = DateTime.Parse("2019-09-01")
            };

            var baker = new Student
            {
                FirstMidName = "Sam",
                LastName = "Baker",
                EnrollmentDate = DateTime.Parse("2011-09-01")
            };

            var abercrombie = new Instructor
            {
                FirstMidName = "Kim",
                LastName = "Abercrombie",
                HireDate = DateTime.Parse("1995-03-11")
            };

            var fakhouri = new Instructor
            {
                FirstMidName = "Fadi",
                LastName = "Fakhouri",
                HireDate = DateTime.Parse("2002-07-06")
            };

            var harui = new Instructor
            {
                FirstMidName = "Roger",
                LastName = "Harui",
                HireDate = DateTime.Parse("1998-07-01")
            };

            var kapoor = new Instructor
            {
                FirstMidName = "Candace",
                LastName = "Kapoor",
                HireDate = DateTime.Parse("2001-01-15")
            };

            var zheng = new Instructor
            {
                FirstMidName = "Roger",
                LastName = "Zheng",
                HireDate = DateTime.Parse("2004-02-12")
            };

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    Instructor = fakhouri,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    Instructor = harui,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    Instructor = kapoor,
                    Location = "Thompson 304" },
            };

            context.AddRange(officeAssignments);

            var WebDevelopment = new Department
            {
                Name = "Web Development",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = abercrombie
            };

            var Computing = new Department
            {
                Name = "Computing",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = fakhouri
            };

            var WebApplication = new Course
            {
                CourseID = 1050,
                CourseCode = "CO550",
                Title = "Web Application",
                Credits = 15,
                Department = WebDevelopment,
                Instructors = new List<Instructor> { kapoor, harui }
            };

            var NetworkSystem = new Course
            {
                CourseID = 4022,
                Title = "Network System",
                CourseCode = "CO556",
                Credits = 15,
                Department = WebDevelopment,
                Instructors = new List<Instructor> { zheng }
            };

            var DatabaseDesign = new Course
            {
                CourseID = 4041,
                CourseCode = "CO558",
                Title = "Database Design",
                Credits = 15,
                Department = WebDevelopment,
                Instructors = new List<Instructor> { zheng }
            };

            var ObjectOrientedSystem = new Course
            {
                CourseID = 1045,
                CourseCode = "CO567",
                Title = "Object Oriented System",
                Credits = 15,
                Department = WebDevelopment,
                Instructors = new List<Instructor> { fakhouri }
            };

            var OpenSourcSystem = new Course
            {
                CourseID = 3141,
                CourseCode = "CO551",
                Title = "Open Source System",
                Credits = 15,
                Department = Computing,
                Instructors = new List<Instructor> { harui }
            };

            var WebServices = new Course
            {
                CourseID = 2021,
                CourseCode = "CO565",
                Title = "Web Services",
                Credits = 15,
                Department = WebDevelopment,
                Instructors = new List<Instructor> { abercrombie }
            };

            var SoftwareEngineering = new Course
            {
                CourseID = 2042,
                CourseCode = "CO557",
                Title = "Software Engineering",
                Credits = 15,
                Department = Computing,
                Instructors = new List<Instructor> { abercrombie }
            };

            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    Student = nawagamuwage,
                    Course = WebApplication,
                    Grade = Grade.A
                },
                    new Enrollment {
                    Student = nawagamuwage,
                    Course = NetworkSystem,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    Student = nawagamuwage,
                    Course = ObjectOrientedSystem,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    Student = nawagamuwage,
                    Course = DatabaseDesign,
                    Grade = Grade.A
                    },
                    new Enrollment {
                    Student = miles,
                    Course = SoftwareEngineering,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    Student = miles,
                    Course = NetworkSystem,
                    Grade = Grade.C
                    },
                    new Enrollment {
                    Student = brooks,
                    Course = DatabaseDesign,
                    },
                    new Enrollment {
                    Student = brooks,
                    Course = WebApplication,
                    Grade = Grade.F
                    },
                    new Enrollment {
                    Student = fast,
                    Course = DatabaseDesign,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    Student = king,
                    Course = NetworkSystem,
                    Grade = Grade.A
                    },
                    new Enrollment {
                    Student = king,
                    Course = ObjectOrientedSystem,
                    Grade = Grade.D
                    }
            };

            context.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}

