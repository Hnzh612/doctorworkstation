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
    public class healthDataController : ControllerBase
    {
        private readonly IhealthDataServices _dataServices;

        public healthDataController(IhealthDataServices dataServices)
        {
            _dataServices = dataServices;
        }

        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        [Route("/HealthData/GetAllData")]
        [HttpGet]
        public List<healthData> GetAllFirst()
        {
            return _dataServices.GetAllData();
        }
        /// <summary>
        /// 返回近七天数据
        /// </summary>
        /// <returns></returns>
        [Route("/HealthData/GetRencentData")]
        [HttpGet]
        public List<healthData> GetRencentData()
        {
            Console.WriteLine(_dataServices.GetRencentData());
            return _dataServices.GetRencentData();
        }
        /// <summary>
        /// 返回近七天运动数据
        /// </summary>
        /// <returns></returns>
        [Route("/HealthData/GetRencentSportData")]
        [HttpGet]
        public List<String> GetRencentSportData()
        {
            return _dataServices.GetRencentSportData();
        }
        /// <summary>
        /// 返回近七天心率数据
        /// </summary>
        /// <returns></returns>
        [Route("/HealthData/GetRencentHeartData")]
        [HttpGet]
        public List<String> GetRencentHeartData()
        {
            return _dataServices.GetRencentHeartData();
        }
        /// <summary>
        /// 返回近七天收缩压数据
        /// </summary>
        /// <returns></returns>
        [Route("/HealthData/GetRencentSPressureData")]
        [HttpGet]
        public List<String> GetRencentSPressureData()
        {
            return _dataServices.GetRencentSPressureData();
        }
        /// <summary>
        /// 返回近七天舒张压数据
        /// </summary>
        /// <returns></returns>
        [Route("/HealthData/GetRencentDPressureData")]
        [HttpGet]
        public List<String> GetRencentDPressureData()
        {
            return _dataServices.GetRencentDPressureData();
        }
    }
}
