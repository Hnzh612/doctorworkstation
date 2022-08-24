using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using highblood.Model;
using SqlSugar;

namespace highblood.Services
{
    public class UserServices : IUserServices
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3306;uid=root;pwd=123456;database=test;charset=utf8mb4;",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        public List<user> GetAllUser()
        {
            return db.Queryable<user>().ToList();
        }
        /// <summary>
        /// 根据Id返回数据
        /// </summary>
        /// <returns></returns>
        public user GetIdUser(int id)
        {
            return db.Queryable<user>().First(u => u.UId == id);
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="u1"></param>
        /// <returns></returns>
        public int AddUser(user u1)
        {
            //try
            //{
               return db.Insertable(u1).ExecuteCommand();
            //}
            //catch
            //{
            //    return 0;
            //}
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="u1"></param>
        /// <returns></returns>
        public int DelUser(int id)
        {
            try
            {
                db.Deleteable<Appointment>().Where(it => it.UId == id).ExecuteCommand();
                db.Deleteable<Bodydata>().Where(it => it.UId == id).ExecuteCommand();
                return db.Deleteable<user>().Where(it => it.UId == id).ExecuteCommand();
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
        public int UpdateUser(user u1)
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
