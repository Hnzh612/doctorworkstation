using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class healthDataServices : Dbservice, IhealthDataServices
    {
        public healthDataServices() : base()
        {

        }
        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        public List<healthData> GetAllData()
        {
            return db.Queryable<healthData>().ToList();
        }
        /// <summary>
        /// 根据id返回数据
        /// </summary>
        /// <returns></returns>
        public List<healthData> GetDataById(int id)
        {
            return db.Queryable<healthData>().Where(it => it.uid == id).ToList();
        }
        /// <summary>
        /// 返回最近七天数据
        /// </summary>
        /// <returns></returns>
        public List<healthData> GetRencentData()
        {
            var all = db.Queryable<healthData>().Take(7).OrderBy(it => it.Date, OrderByType.Desc).ToList();
            return all;
        }
        /// <summary>
        /// 返回最近七天运动数据
        /// </summary>
        /// <returns></returns>
        public List<string> GetRencentSportData()
        {
            var sport= db.Queryable<healthData>().Take(7).OrderBy(it => it.Date, OrderByType.Desc).Select(it => it.Steps).ToList();
            return sport;
        }
        /// <summary>
        /// 返回最近七天心率数据
        /// </summary>
        /// <returns></returns>
        public List<string> GetRencentHeartData()
        {
            var HeartRate = db.Queryable<healthData>().Take(7).OrderBy(it => it.Date, OrderByType.Desc).Select(it => it.HeartRate).ToList();
            return HeartRate;
        }
        /// <summary>
        /// 返回最近七天收缩压数据
        /// </summary>
        /// <returns></returns>
        public List<string> GetRencentSPressureData()
        {
            var SPressure = db.Queryable<healthData>().Take(7).OrderBy(it => it.Date, OrderByType.Desc).Select(it => it.SystolicPressure).ToList();
            return SPressure;
        }
        /// <summary>
        /// 返回最近七天舒张压数据
        /// </summary>
        /// <returns></returns>
        public List<string> GetRencentDPressureData()
        {
            var DPressure = db.Queryable<healthData>().Take(7).OrderBy(it => it.Date, OrderByType.Desc).Select(it => it.DiastolicPressure).ToList();
            return DPressure;
        }
        //添加健康数据
        public int AddhealthData(healthData h1)
        {
            //try
            //{
            return db.Insertable(h1).ExecuteCommand();
            //}
            //catch
            //{
            //    return 0;
            //}
        }
    }
}
