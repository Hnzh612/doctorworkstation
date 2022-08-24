using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("displayVideo")]
    public class displayVideo
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int VId { get; set; }
        public int DId { get; set; }
        public string VPhoto_Path { get; set; }
        public string VTitle { get; set; }
        public string DPhoto_Path { get; set; }
        public string DName { get; set; }
        public DateTime VTime { get; set; }
    }
}
