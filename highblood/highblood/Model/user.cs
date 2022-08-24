using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("User")]
    public class user
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int UId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool Diabetes { get; set; }
        public bool Alcoholism { get; set; }
        public bool Smoke { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string UIdennum { get; set; }
        public int DataId { get; set; }
        public string UAddress { get; set; }
        public int UAge { get; set; }
        public int Did { get; set; }
    }
}
