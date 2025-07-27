
namespace StudentManagementSystem
{
    internal class SchoolStudentManager
    {
        public List<Student> Students = new List<Student>();
        public List<Course> courses = new List<Course>();
        public List<Instructor> instructors = new List<Instructor>();

        public bool AddStudent(Student student) 
        {
            if (FindStudent(student.StudentId) != null)
            {
                return false;
            }
            else
            {
                Students.Add(student);
            }
            return true;
        }
        public bool AddCourse(Course course) 
        {
            if (FindCourse(course.CourseID) != null )
                return false;
            else
                courses.Add(course);
            return true;
        }
        public bool AddInstructor(Instructor instructor) 
        { 
            if(FindInstructor(instructor.InstructorId) != null) return false;
            instructors.Add(instructor);
            return true;
        }
        public Student FindStudent(int studentId)
        {
            for(int i = 0;  i < Students.Count; i++)
            {
                if (studentId == Students[i].StudentId)
                {
                    return Students[i];
                }
                
            }
            return null;
        }
        public Student FindStudent(string name)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (name == Students[i].Name)
                {
                    return Students[i];
                }

            }
            return null;
        }
        public Course FindCourse(int courseId) 
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courseId == courses[i].CourseID)
                {
                    return courses[i];
                }

            }
            return null;
        }
        public Course FindCourse(string title) 
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (title == courses[i].Title)
                {
                    return courses[i];
                }

            }
            return null;
        }
        public Instructor FindInstructor(int instructorId) 
        { 
            for(int i = 0; i < instructors.Count;i++)
            {
                if(instructorId ==  instructors[i].InstructorId)
                {
                    return instructors[i];
                }
            }
            return null;
        }
        public bool EnrollStudentInCourse(int studentId, int courseId) 
        {
            for(int i = 0; i < Students.Count;i++)
            {
                if(studentId == Students[i].StudentId)
                {
                    Student student = Students[i];
                    student.Enroll(FindCourse(courseId));
                    return true;
                }
            }
            return false;
        }

        public string CheckIfStudentEnrolled(int studentId)
        {
            Student student = FindStudent(studentId);
            
            if (student.courses.Count != 0)
            {
                string studentCourses = "";
                for (int i = 0; i < student.courses.Count; i++)
                {
                    studentCourses += student.courses[i].PrintDetails() + "\n";
                }
                return studentCourses;
            }
            return "Student have not any Courses";
        }

        
        public void DisplayMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                           ╔═════ Main Menu ═══════════════════════════════════════╗");
            Console.WriteLine("                           ║                                                       ║");
            Console.WriteLine("                           ║  1. Add Student                                       ║");
            Console.WriteLine("                           ║  2. Add Instructor                                    ║");
            Console.WriteLine("                           ║  3. Add Course                                        ║");
            Console.WriteLine("                           ║  4. Enroll Student in Course                          ║");
            Console.WriteLine("                           ║  5. Show All Students                                 ║");
            Console.WriteLine("                           ║  6. Show All Courses                                  ║");
            Console.WriteLine("                           ║  7. Show All Instructors                              ║");
            Console.WriteLine("                           ║  8. Find the student by id or name                    ║");
            Console.WriteLine("                           ║  9. Fine the course by id or name                     ║");
            Console.WriteLine("                           ║ 10. Check if the student enrolled in specific course  ║");
            Console.WriteLine("                           ║ 11. Return the instructor name by course name         ║");
            Console.WriteLine("                           ║ 12. Delete a Student                                  ║");
            Console.WriteLine("                           ║ 13. Exit                                              ║");
            Console.WriteLine("                           ╚═══════════════════════════════════════════════════════╝");
            Console.Write("==>");
        }

    }
}
