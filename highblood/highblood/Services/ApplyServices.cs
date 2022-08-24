using highblood.IServices;
using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class ApplyServices:IApplyServices
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3306;uid=root;pwd=123456;database=test;charset=utf8mb4;",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        public List<Apply> GetApply()
        {
            return db.Queryable<Apply>().ToList();
        }
    }
}
