using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Doctor")]
    public class doctor
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int DId { get; set; }
        public string DPhoto_Path { get; set; }
        public string DName { get; set; }
        public string DHospital { get; set; }
        public string DDepart { get; set; }
        public string DTitle { get; set; }
        public string DTime { get; set; }
        public string DIntroduce { get; set; }
        public DateTime DVisitTime { get; set; }
    }
}
