using highblood.IServices;
using highblood.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace highblood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserinformationController : ControllerBase
    {
        private readonly IUserinformationServices _userinformationServices;

        public UserinformationController(IUserinformationServices userinformationServices)
        {
            _userinformationServices = userinformationServices;
        }

        /// <summary>
        /// 返回所有用户数据
        /// </summary>
        /// <returns></returns>
        [Route("/User/GetAllUserinforamtion")]
        [HttpGet]
        public CallBack GetAllUserinforamtion(int page, string name, int age, string sex)
        {
            return _userinformationServices.GetAllUserinforamtion(page, name, age,  sex);
        }

        /// <summary>
        /// 根据id返回用户
        /// </summary>
        /// <returns></returns>
        [Route("/User/GetIdUserinforamtion")]
        [HttpGet]
        public userinformation GetIdUserinforamtion(string id)
        {
            return _userinformationServices.GetIdUserinforamtion(id);
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        [Route("/User/AddUserinforamtion")]
        [HttpPost]
        public int AddUserinforamtion(userinformation u1)
        {
            return _userinformationServices.AddUserinforamtion(u1);
        }
        /// <summary>
        /// 根据id删除用户
        /// </summary>
        /// <returns></returns>
        [Route("/User/DelUserinforamtion")]
        [HttpGet]
        public int DelUserinforamtion(string id)
        {
            return _userinformationServices.DelUserinforamtion(id);
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <returns></returns>
        [Route("/User/UpdateUserinforamtion")]
        [HttpPost]
        public int UpdateUserinforamtion(userinformation u1)
        {
            return _userinformationServices.UpdateUserinforamtion(u1);
        }
    }
}
