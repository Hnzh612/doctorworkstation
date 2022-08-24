using highblood.IServices;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Model
{
    public class UserinformationServices : IUserinformationServices
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3366;uid=root;pwd=123456 ;database=test",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        /// <summary>
        /// 返回所有用户数据
        /// </summary>
        /// <returns></returns>
        public List<userinformation> GetAllUserinforamtion()
        {
            return db.Queryable<userinformation>().ToList();
        }
        /// <summary>
        /// 根据Id返回数据
        /// </summary>
        /// <returns></returns>
        public userinformation GetIdUserinforamtion(string id)
        {
            return db.Queryable<userinformation>().First(u => u.UId == id);
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="u1"></param>
        /// <returns></returns>
        public int AddUserinforamtion(userinformation u1)
        {
            return db.Insertable(u1).ExecuteCommand();
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="u1"></param>
        /// <returns></returns>
        public int DelUserinforamtion(string id)
        {
            try
            {
                return db.Deleteable<userinformation>().Where(it => it.UId == id).ExecuteCommand();
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="u1"></param>
        /// <returns></returns>
        public int UpdateUserinforamtion(userinformation u1)
        {
            try
            {
                var result = db.Updateable(u1).ExecuteCommand();
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
