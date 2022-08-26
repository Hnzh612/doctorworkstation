using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class FollowupServices : Dbservice, IFollowupServices
    {
        public FollowupServices() : base()
        {

        }
        public List<Followup> GetFollowup()
        {
            return db.Queryable<Followup>().ToList();
        }
    }
}
