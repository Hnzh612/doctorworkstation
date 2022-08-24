using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("ShouJianXiang")]
    public class ShouJianXiang
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string Snumber { get; set; }
        public DateTime Stime { get; set; }
        public string Stypes { get; set; }
        public string SDetailed { get; set; }
        public string SContent { get; set; }
    }
}
