using highblood.IServices;
using highblood.Services;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace highblood.Model
{
    public class UserinformationServices : Dbservice, IUserinformationServices
    {
        public UserinformationServices() : base()
        {

        }
        /// <summary>
        /// 返回所有用户数据
        /// </summary>
        /// <returns></returns>
        public CallBack GetAllUserinforamtion(int page,string name,int age,string sex)
        {
            CallBack callBack = new CallBack();
            string querysql = $"select u.*,b.BDate,b.BBloodpresure from user u left join bodydata b on u.uid=b.UId where 1=1 ";
            if (!string.IsNullOrEmpty(name))
            {
                querysql += $" and Name='{name}'";
            }
            if (age > 0)
            {
                querysql += $" and UAge='{age}'";
            }
            if (!string.IsNullOrEmpty(sex))
            {
                querysql += $" and Sex='{sex}'";
            }
            querysql += $" limit {(page - 1) * 10},{page*10}";
            callBack.message = db.Ado.GetInt("select count(1) from user").ToString(); 
            callBack.successed = true; 
            callBack.data= db.Ado.SqlQuery<dynamic>(querysql);
            return callBack;
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
