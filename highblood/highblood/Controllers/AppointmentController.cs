using highblood.IServices;
using highblood.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentServices _AppointmentServices;

        public AppointmentController(IAppointmentServices AppointmentServices)
        {
            _AppointmentServices = AppointmentServices;
        }

        /// <summary>
        /// 返回所有预约信息
        /// </summary>
        /// <returns></returns>
        [Route("/Appointment/GetAppointment")]
        [HttpGet]
        public List<Appointment> GetAppointment()
        {
            return _AppointmentServices.GetAppointment();
        }
    }
}
