using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Followup")]
    public class Followup
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string FID { get; set; }
        public int FState { get; set; }
        public string FDate { get; set; }        
        public string FContent { get; set; }
        public int UId { get; set; }
        public int DId { get; set; }
        public string Name { get; set; }
    }
}
