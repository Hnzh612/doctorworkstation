using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Formulation")]
    public class Formulation
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int UId { get; set; }
        public string FOCharg { get; set; }
        public string FOYib { get; set; }
        public string FOKeb { get; set; }
        public string FOTest { get; set; }
        public string FOMenz { get; set; }
        public string FOR { get; set; }
        public string FODate { get; set; }
    }
}
