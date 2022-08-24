using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Video")]
    public class video
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int VId { get; set; }
        public int DId { get; set; }
        public string VPhoto_Path { get; set; }
        public string VTitle { get; set; }
        public DateTime VTime { get; set; }
        public string VType { get; set; }
        public string VLength { get; set; }
        public string VCollect { get; set; }
        public string VAgree { get; set; }
    }
}
