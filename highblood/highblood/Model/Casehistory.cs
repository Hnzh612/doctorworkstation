using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Casehistory")]
    public class Casehistory
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string CID { get; set; }
        public int UId { get; set; }
        public DateTime CDate { get; set; }
        public string CHospital { get; set; }
        public string CAio { get; set; }
        public string CHoi { get; set; }
        public string CPrehis { get; set; }
        public string CExam { get; set; }
        public string CPridia { get; set; }
        public string CTreat { get; set; }  
        public string CAnnoun { get; set; }
    }
}
