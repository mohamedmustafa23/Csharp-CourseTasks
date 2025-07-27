
namespace StudentManagementSystem
{
    internal class Course
    {
        public int CourseID;
        public string Title;
        public Instructor Instructor;

        public Course(int courseID, string title, Instructor instructor)
        {
            CourseID = courseID;
            Title = title;
            Instructor = instructor;
        }

        public string PrintDetails()
        {
            return $"CourseID: {CourseID}, Title: {Title}, Instructor: {Instructor.Name}";
        }
    }
}
