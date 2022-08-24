using SqlSugar;
using System.Security.Principal;

namespace highblood.Model
{
    [SugarTable("admin")]
    public class admin
    {

        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int type { get; set; }
    }
}

