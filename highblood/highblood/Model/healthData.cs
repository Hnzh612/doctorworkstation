using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
        [SugarTable("HealthData")]
        public class healthData
        {
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public int DataId { get; set; }
            public string DeviceName { get; set; }
            public string SystolicPressure { get; set; }
            public string DiastolicPressure { get; set; }
            public string HeartRate { get; set; }
            public string Steps { get; set; }
            public string Date { get; set; }

    }
}
