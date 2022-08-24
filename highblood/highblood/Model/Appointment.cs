using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Appointment")]
    public class Appointment
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string AID { get; set; }
        public int UId { get; set; }
        public DateTime ADate { get; set; }
        public string AContent { get; set; }
        public int DId { get; set; }
    }
}
