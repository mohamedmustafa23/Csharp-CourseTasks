namespace Hospital.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Specialization {  get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public List<Appointment> Appointments { get; set; } = new();

    }
}
