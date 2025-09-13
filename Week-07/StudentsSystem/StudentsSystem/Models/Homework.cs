namespace StudentsSystem.Models
{
    public enum ContentType { Application, Pdf, Zip}
    public class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; } = null!;
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
