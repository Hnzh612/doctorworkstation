using highblood.Model;
using highblood.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        [Route("/User/GetAllUser")]
        [HttpGet]
        public List<user> GetAllUser()
        {
            return _userServices.GetAllUser();
        }

        /// <summary>
        /// 根据id返回数据
        /// </summary>
        /// <returns></returns>
        [Route("/User/GetUserById")]
        [HttpGet]
        public user GetIdUser(string id)
        {
            return _userServices.GetIdUser(id);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns></returns>
        [Route("/User/AddUser")]
        [HttpPost]
        public int AddUser(user u1)
        {
            return _userServices.AddUser(u1);
        }
        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <returns></returns>
        [Route("/User/DelUser")]
        [HttpGet]
        public int DelUser(string id)
        {
            return _userServices.DelUser(id);
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <returns></returns>
        [Route("/User/UpdateUser")]
        [HttpPost]
        public int UpdateUser(user u1)
        {
            return _userServices.UpdateUser(u1);
        }
    }
}
