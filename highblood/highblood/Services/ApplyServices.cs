using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class ApplyServices :Dbservice ,IApplyServices
    {
        public ApplyServices() : base()
        {

        }
        public List<Apply> GetApply()
        {
            return db.Queryable<Apply>().ToList();
        }
    }
}
