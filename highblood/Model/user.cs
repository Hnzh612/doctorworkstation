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
        public string UId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool Diabetes { get; set; }
        public bool Alcoholism { get; set; }
        public bool Smoke { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
