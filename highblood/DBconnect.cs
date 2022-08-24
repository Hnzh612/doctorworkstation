using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood
{
    public class DBconnect
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3366;uid=root;pwd=123456 ;database=highblood",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
    }
}
