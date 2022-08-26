using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class CasehistoryServices : Dbservice, ICasehistoryServices
    {
        public CasehistoryServices() : base()
        {

        }
        public List<Casehistory> GetCasehistory()
        {
            return db.Queryable<Casehistory>().ToList();
        }
        public List<Casehistory> GetIdCase(int id)
        {
            return db.Queryable<Casehistory>().Where(u => u.UId == id).ToList(); 
        }
    }
}
