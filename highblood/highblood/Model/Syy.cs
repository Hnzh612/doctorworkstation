using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    [SugarTable("Syy")]

    public class syy
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Dasda { get; set; }
        [SugarColumn(ColumnDataType ="nvarchar")]
        public string Gv { get; set; }
    }
}
