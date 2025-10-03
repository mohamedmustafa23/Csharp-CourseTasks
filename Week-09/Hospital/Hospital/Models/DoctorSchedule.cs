namespace Hospital.Models
{
    public class DoctorSchedule
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string WeekDays { get; set; } = string.Empty;     
        public TimeOnly Time { get; set; }     
        public bool IsBooked { get; set; }     

        public Doctor Doctor { get; set; } = new Doctor();
    }
}
