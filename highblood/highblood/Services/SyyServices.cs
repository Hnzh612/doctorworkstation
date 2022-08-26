using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class SyyServices : Dbservice, ISyyServices
    {
        public SyyServices() : base()
        {

        }
        public List<syy> GetSyys()
        {
            return db.Queryable<syy>().ToList();
        }
    }
}
