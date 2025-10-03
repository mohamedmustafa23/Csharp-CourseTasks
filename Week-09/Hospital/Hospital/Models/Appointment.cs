namespace Hospital.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public string PatientName { get; set; } = string.Empty;

        public string WeekDay { get; set; } = string.Empty; 

        public TimeOnly Time { get; set; }

        public string Phone { get; set; } = string.Empty;

        public bool IsBooked { get; set; } = false;
    }
}
