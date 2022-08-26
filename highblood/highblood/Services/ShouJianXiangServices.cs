﻿using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class ShouJianXiangServices : Dbservice, IShouJianXiangServices
    {
        public ShouJianXiangServices() : base()
        {

        }
        public List<ShouJianXiang> GetMail()
        {
            return db.Queryable<ShouJianXiang>().ToList();
        }
    }
}
