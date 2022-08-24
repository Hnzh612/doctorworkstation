using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class DoctorServices : IDoctorServices
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3366;uid=root;pwd=123456 ;database=test",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        /// <summary>
        /// 返回所有医生信息
        /// </summary>
        /// <returns></returns>
        public List<doctor> GetAllDoctor()
        {
            return db.Queryable<doctor>().ToList();
        }
        /// <summary>
        /// 根据id查找医生信息
        /// </summary>
        /// <returns></returns>
        public List<doctor> GetDoctorById(int Did)
        {
            return db.Queryable<doctor>().Where(d => d.DId == Did).ToList();
        }
        /// <summary>
        /// 根据姓名查找医生信息
        /// </summary>
        /// <returns></returns>
        public List<doctor> GetDoctorByName(string DName)
        {
            return db.Queryable<doctor>().Where(it => it.DName.Contains(DName)).ToList();
        }
    }
}
