using highblood.Model;
using highblood.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorServices _doctorServices;

        public DoctorController(IDoctorServices doctorServices)
        {
            _doctorServices = doctorServices;
        }

        /// <summary>
        /// 返回所有医生信息
        /// </summary>
        /// <returns></returns>
        [Route("/Doctor/GetAllDoctor")]
        [HttpGet]
        public List<doctor> GetAllDoctor()
        {
            return _doctorServices.GetAllDoctor();
        }
        /// <summary>
        /// 根据id查找医生信息
        /// </summary>
        /// <returns></returns>
        [Route("/Doctor/GetDoctorById")]
        [HttpGet]
        public List<doctor> GetDoctorById(int Did)
        {
            return _doctorServices.GetDoctorById(Did);
        }
        /// <summary>
        /// 根据姓名查找医生信息
        /// </summary>
        /// <returns></returns>
        [Route("/Doctor/GetDoctorByName")]
        [HttpGet]
        public List<doctor> GetDoctorByName(string DName)
        {
            return _doctorServices.GetDoctorByName(DName);
        }
    }
}
