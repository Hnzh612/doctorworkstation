using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Bodydata")]
    public class Bodydata
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int BID { get; set; }
        public int UId { get; set; }
        public DateTime BDate { get; set; }
        public string BBloodpresure { get; set; }
        public double BBloodglucose { get; set; }
        public double BBloodOxygen { get; set; }
        public string BHeartrate { get; set; }
        public string BStep { get; set; }
    }
}
