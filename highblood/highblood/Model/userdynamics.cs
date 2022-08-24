using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("userdynamics")]
    public class userdynamics
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int UDId { get; set; }
        public string UId { get; set; }
        public DateTime UDDate { get; set; }
        public string UDContent { get; set; }
        public string UDPath { get; set; }
        public Byte UDFollow { get; set; }
        public int UDShare { get; set; }
        public int UDComment { get; set; }
        public int UDAgree { get; set; }

    }
}
