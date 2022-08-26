using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class BodydataServices : Dbservice, IBodydataServices
    {
        public BodydataServices() : base()
        {

        }
        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        public List<Bodydata> GetBodydata()
        {
            return db.Queryable<Bodydata>().ToList();
        }
        /// <summary>
        /// 根据Id返回数据
        /// </summary>
        /// <returns></returns>
        public Bodydata GetIdBodydata(int id)
        {
            return db.Queryable<Bodydata>().First(u => u.BID == id);
        }
    }
}
