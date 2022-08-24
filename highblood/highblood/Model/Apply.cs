using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Apply")]
    public class Apply
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string APID { get; set; }
        public int UId { get; set; }
        public string APStatus { get; set; }
        public DateTime APDate { get; set; }
    }
}
