using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public interface IDoctorServices
    {
        /// <summary>
        /// 返回所有医生信息
        /// </summary>
        /// <returns></returns>
        public List<doctor> GetAllDoctor();
        /// <summary>
        /// 根据id查找医生信息
        /// </summary>
        /// <returns></returns>
        public List<doctor> GetDoctorById(int Did);
        /// <summary>
        /// 根据姓名查找医生信息
        /// </summary>
        /// <returns></returns>
        public List<doctor> GetDoctorByName(string DName);
    }
}
