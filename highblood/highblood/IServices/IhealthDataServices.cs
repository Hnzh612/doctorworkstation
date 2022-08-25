using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public interface IhealthDataServices
    {
        /// <summary>
        /// 返回所有监测数据
        /// </summary>
        /// <returns></returns>
        public List<healthData> GetAllData();
        /// <summary>
        /// 返回近七天数据
        /// </summary>
        /// <returns></returns>
        public List<healthData> GetDataById(int id);
        public List<healthData> GetRencentData();
        /// <summary>
        /// 返回近七天运动数据
        /// </summary>
        /// <returns></returns>
        public List<String> GetRencentSportData();
        /// <summary>
        /// 返回近七天心率数据
        /// </summary>
        /// <returns></returns>
        public List<String> GetRencentHeartData();
        /// <summary>
        /// 返回近七天收缩压数据
        /// </summary>
        /// <returns></returns>
        public List<String> GetRencentSPressureData();
        /// <summary>
        /// 返回近七天舒张压数据
        /// </summary>
        /// <returns></returns>
        public List<String> GetRencentDPressureData();
        public int AddhealthData(healthData h1);
    }
}
