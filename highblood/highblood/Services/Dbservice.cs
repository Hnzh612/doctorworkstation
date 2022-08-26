using SqlSugar;

namespace highblood.Services
{
    public class Dbservice
    {
        public SqlSugarClient db;
        public Dbservice()
        {
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=localhost;port=3306;uid=root;pwd=123456;database=test;charset=utf8mb4;",
                DbType = DbType.MySql,
                IsAutoCloseConnection = true
            });
        }
    }
}
