namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolStudentManager studentManager = new SchoolStudentManager();

            while (true)
            {
                studentManager.DisplayMainMenu();
                string input = Console.ReadLine();
                int choose;
                if (int.TryParse(input, out choose))
                {
                    switch (choose)
                    {
                        case 1:
                            Console.Write("Enter your name:");
                            string studantName = Console.ReadLine()!;
                            Console.Write("Enter your age:");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter your ID:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (studentManager.AddStudent(new Student(id, studantName, age)))
                            {
                                Console.WriteLine("Student added successfully");
                            }
                            else
                            {
                                Console.WriteLine("Id number already added Please try again");
                            }
                            break;

                        case 2:
                            Console.Write("Enter instructor Name:");
                            string instName = Console.ReadLine();
                            Console.Write("Enter instructor ID:");
                            int instructorId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter instructor Specialization:");
                            string specialization = Console.ReadLine();
                            if (studentManager.AddInstructor(new Instructor(instructorId, instName, specialization)))
                            {
                                Console.WriteLine("Instructor added successfully");
                            }
                            else
                            {
                                Console.WriteLine("Id number already added Please try again");
                            }
                            
                            break;

                        case 3:
                            Console.WriteLine("Enter Course Title:");
                            string courseName = Console.ReadLine();
                            Console.WriteLine("Enter Course ID:");
                            int courseId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter instructor ID:");
                            int CourseInstructor = Convert.ToInt32(Console.ReadLine());
                            Instructor instructor = studentManager.FindInstructor(CourseInstructor);
                            if(studentManager.instructors.Count == 0)
                            {
                                Console.WriteLine("PLease Enter Instructor First");
                                continue;
                            }
                            else if (studentManager.FindInstructor(CourseInstructor) == null)
                            {
                                Console.WriteLine("Instructor Id not found");
                            }
                            else if (studentManager.AddCourse(new Course(courseId, courseName, instructor)))
                            {
                                Console.WriteLine("Course added successfully");
                            }
                            else
                            {
                                Console.WriteLine("Id number already added Please try again");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter Student Id:");
                            int studentID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Course ID:");
                            int courseID = Convert.ToInt32(Console.ReadLine());
                            studentManager.EnrollStudentInCourse(studentID, courseID);
                            Console.WriteLine("Course added to Student successfully");
                            break;
                        case 5:
                            for (int i = 0; i < studentManager.Students.Count; i++)
                            {
                                Console.WriteLine(studentManager.Students[i].PrintDetails());
                            }
                            break;

                        case 6:
                            for (int i = 0; i < studentManager.courses.Count; i++)
                            {
                                Console.WriteLine(studentManager.courses[i].PrintDetails());
                            }
                            break;

                        case 7:
                            for (int i = 0; i < studentManager.instructors.Count; i++)
                            {
                                Console.WriteLine(studentManager.instructors[i].PrintDetails());
                            }
                            break;

                        case 8:
                            Console.Write("Enter Student ID or Name:");
                            string studentNameOrId = Console.ReadLine();
                            if (studentNameOrId.All(char.IsDigit))
                            {
                                int studentByID = Convert.ToInt32(studentNameOrId);
                                Student student = studentManager.FindStudent(studentByID);
                                Console.WriteLine(student.PrintDetails());
                            }
                            else
                            {
                                Student student = studentManager.FindStudent(studentNameOrId);
                                Console.WriteLine(student.PrintDetails());
                            }
                            break;

                        case 9:
                            Console.Write("Enter Course ID or Name:");
                            string courseNameOrId = Console.ReadLine();
                            if (courseNameOrId.All(char.IsDigit))
                            {
                                int courseByID = Convert.ToInt32(courseNameOrId);
                                Course course = studentManager.FindCourse(courseByID);
                                Console.WriteLine(course.PrintDetails());
                            }
                            else
                            {
                                Course course = studentManager.FindCourse(courseNameOrId);
                                Console.WriteLine(course.PrintDetails());
                            }
                            break;

                        case 10:
                            Console.Write("Enter Student ID:");
                            int studentcoursid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(studentManager.CheckIfStudentEnrolled(studentcoursid));
                            break;

                        case 11:
                            Console.Write("Enter Course Name:");
                            string nam = Console.ReadLine();
                            Course instructorCourse = studentManager.FindCourse(nam);
                            Instructor instructor1 = instructorCourse.Instructor;
                            Console.WriteLine(instructor1.PrintDetails());
                            break;

                        case 12:
                            Console.Write("Enter Student Id:");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Student y = studentManager.FindStudent(x);
                            studentManager.Students.Remove(y);
                            Console.WriteLine("Student Removed successfully");
                            break;

                        case 13:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Unknown selection, please try again");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Number From 1 to 13");
                }


            }
        }
    }
}
