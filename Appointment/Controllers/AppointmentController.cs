﻿using Appointments.Models;
using Appointments.Service;
using Microsoft.AspNetCore.Mvc;

namespace Appointments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : Controller
    {
        private readonly AppointmentService _appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }


        [HttpGet(Name = "GetAppointment")]
        public IEnumerable<Appointment> Get()
        {
            var listOfAppointments = _appointmentService.GetAppointments();

            return listOfAppointments;
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
