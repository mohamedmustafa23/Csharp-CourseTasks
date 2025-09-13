
namespace StudentsSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!; // هنا !null معناها ان انا بقول لل Compiler متقلقش القيمه دي عمرها م هتكون ب null 
        public string? PhoneNumber { get; set; } //هنا String? ده معناه ان ممكن عادي اخلي الفون نمبر يكون بيساوي null
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }


        public ICollection<Homework> Homeworks { get; set; } = new HashSet<Homework>(); // هنا انا استخدمت HashSet مش list لسببين الاول انها اسرع شويه في البحث والتاني انها بتمنع التكرار 
        public ICollection<Course> StudentCourses { get; set; } = new HashSet<Course>();

    }
}
