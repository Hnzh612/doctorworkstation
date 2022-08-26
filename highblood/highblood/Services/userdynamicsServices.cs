using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class userdynamicsServices : Dbservice, IuserdynamicsServices
    {
        public userdynamicsServices() : base()
        {

        }
        public List<userdynamics> GetIuserdynamicsServices()
        {
            return db.Queryable<userdynamics>().ToList();
        }
    }
}
