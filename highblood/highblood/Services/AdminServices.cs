using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using highblood.IServices;
using highblood.Model;
using Newtonsoft.Json;
using SqlSugar;

namespace highblood.Services
{
    public class AdminServices : Dbservice, IAdminServices
    {
        public AdminServices() : base()
        {

        }
        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        public List<admin> GetAllAdmin()
        {
            return db.Queryable<admin>().ToList();
        }
        /// <summary>
        /// 根据用户名返回数据
        /// </summary>
        /// <returns></returns>
        public CallBack Login(string username,string password)
        {
            CallBack callBack = new CallBack();
            admin admin =  db.Queryable<admin>().First(u => u.username == username);
            if(admin.password == password)
            {
                callBack.successed = true;
                callBack.data = admin;
            }
            return callBack;
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="u1"></param>
        /// <returns></returns>
        public int AddAdmin(admin al)
        {
            //try
            //{
               return db.Insertable(al).ExecuteCommand();
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
        public int DelAdmin(int id)
        {
            try
            {
                return db.Deleteable<admin>().Where(it => it.id == id).ExecuteCommand();
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
        public int UpdateAdmin(admin u1)
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
