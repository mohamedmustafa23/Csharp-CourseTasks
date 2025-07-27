
namespace StudentManagementSystem
{
    internal class Instructor
    {
        public int InstructorId;
        public string Name;
        public string Specialization;

        public Instructor(int instructorId, string name, string specialization)
        {
            InstructorId = instructorId;
            Name = name;
            Specialization = specialization;
        }

        public string PrintDetails()
        {
            return $"Instructor Id:{InstructorId}  name is:{Name} Specialization is:{Specialization} ";
        }
    }
}
