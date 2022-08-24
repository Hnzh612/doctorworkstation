using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Article")]
    public class article
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int AId { get; set; }
        public int DId { get; set; }
        public string AType { get; set; }
        public string ATitle { get; set; }
        public string AContent { get; set; }
        public DateTime ATime { get; set; }
        public int ALength { get; set; }
        public int AAgree { get; set; }
        public int ACollect { get; set; }
    }
}
