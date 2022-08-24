using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Userinformation")]
    public class userinformation
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string UId { get; set; }
        public string UName { get; set; }
        public string UPath { get; set; }
    }
}
