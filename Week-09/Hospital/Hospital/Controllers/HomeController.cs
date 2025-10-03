using System.Diagnostics;
using Hospital.DataAccess;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context = new();

        public HomeController(ILogger<HomeController> logger) 
        {
            _logger = logger;
        }

        public IActionResult Index(string specialization, int? minAge, int? maxAge,int page = 1)
        {
            var doctors = _context.Doctors.AsQueryable();

            //Filter

            if (!string.IsNullOrEmpty(specialization) && specialization != "all")
            {
                doctors = doctors.Where(d => d.Specialization == specialization);
            }

            if (minAge.HasValue)
            {
                doctors = doctors.Where(d => d.Age >= minAge.Value);
            }

            if (maxAge.HasValue)
            {
                doctors = doctors.Where(d => d.Age <= maxAge.Value);
            }


            ViewBag.Specialization = specialization;
            ViewBag.MinAge = minAge;
            ViewBag.MaxAge = maxAge;

            //pagination
            ViewBag.TotalPages = Math.Ceiling(doctors.Count() / 8.0);
            ViewBag.CurrentPage = page;
            doctors = doctors.Skip((page - 1) * 8).Take(8);
            

            return View(doctors.ToList());
        }

        public IActionResult Appointment(int doctorId)
        {

            var doctor = _context.Doctors
                .Include(d => d.Appointments)
                .FirstOrDefault(d => d.DoctorId == doctorId);

            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        [HttpGet]
        public IActionResult GetBookedTimes(int doctorId, string selectedDate)
        {
           
            var bookedTimes = _context.Appointments
                .Where(a => a.DoctorId == doctorId && a.WeekDay == selectedDate && a.IsBooked)
                .Select(a => a.Time.ToString("HH:mm")) 
                .ToList();

            return Json(bookedTimes);
        }

        [HttpPost]
        public IActionResult ConfirmAppointment(int doctorId, string name, string phone, string date, TimeOnly time)
        {
            var existingAppointment = _context.Appointments
                .FirstOrDefault(a => a.DoctorId == doctorId && a.WeekDay == date && a.Time == time);

            
            if (existingAppointment != null && existingAppointment.IsBooked)
            {
                ViewBag.ErrorMessage = "This appointment is already booked. Please choose another time.";
                var sameDoctor = _context.Doctors
                                        .Include(d => d.Appointments) 
                                        .FirstOrDefault(d => d.DoctorId == doctorId);

                return View("Appointment", sameDoctor);
            }
            else if (existingAppointment != null && !existingAppointment.IsBooked)
            {
                existingAppointment.PatientName = name;
                existingAppointment.Phone = phone;
                existingAppointment.IsBooked = true;
                _context.Appointments.Update(existingAppointment);
            }
            else
            {
                var appointment = new Appointment
                {
                    DoctorId = doctorId,
                    PatientName = name,
                    WeekDay = date,
                    Time = time,
                    IsBooked = true,
                    Phone = phone
                };
                _context.Appointments.Add(appointment);
            }

            if (ModelState.IsValid)
            {
                _context.SaveChanges();
                ViewBag.SuccessMessage = "Your appointment has been booked successfully";
            }
            else
            {
                ViewBag.ErrorMessage = "Something went wrong. Please try again!";
            }

            var doctor = _context.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);
            return View("Appointment", doctor);
        }

        public IActionResult AppointmentsList()
        {
            var appointments = _context.Appointments
                .Include(a => a.Doctor)
                .OrderByDescending(a => a.AppointmentId) 
                .ToList();

            return View(appointments); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}