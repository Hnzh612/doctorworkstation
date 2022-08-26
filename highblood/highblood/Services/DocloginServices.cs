using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class DocloginServices : Dbservice, IDocloginServices
    {
        public DocloginServices() : base()
        {

        }
        //返回所有账号密码
        public List<Doclogin> GetDoclogin()
        {
            return db.Queryable<Doclogin>().ToList();
        }
    }
}
