using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Doclogin")]

    public class Doclogin
    {

        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string DId { get; set; }
        public string DLPassword { get; set; }
    }
}
