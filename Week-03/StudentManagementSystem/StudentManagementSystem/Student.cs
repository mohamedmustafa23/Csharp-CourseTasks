
namespace StudentManagementSystem
{
    internal class Student
    {
        public int StudentId;
        public string Name;
        public int Age;
        public List<Course> courses = new List<Course>();

        public Student(int studentId, string name, int age)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
        }

        public bool Enroll(Course course)
        {
            courses.Add(course);
            return true;
        }
        public string PrintDetails()
        {
            return $"Student: {StudentId} Name:{Name} Age:{Age}";
        }
    }
}
