using highblood.IServices;
using highblood.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _adminServices;

        public AdminController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        [Route("/Admin/GetAllAdmins")]
        [HttpGet]
        public List<admin> GetAllAdmins()
        {
            return _adminServices.GetAllAdmin();
        }

        /// <summary>
        /// 根据id返回数据
        /// </summary>
        /// <returns></returns>
        [Route("/Admin/Login")]
        [HttpGet]
        public CallBack Login(string username,string password)
        {
            return _adminServices.Login(username,password);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns></returns>
        [Route("/Admin/AddAdmin")]
        [HttpPost]
        public int AddAdmin(admin al)
        {
            return _adminServices.AddAdmin(al);
        }
        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <returns></returns>
        [Route("/Admin/DelAdmin")]
        [HttpGet]
        public int DelAdmin(int id)
        {
            return _adminServices.DelAdmin(id);
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <returns></returns>
        [Route("/Admin/UpdateAdmin")]
        [HttpPost]
        public int UpdateAdmin(admin al)
        {
            return _adminServices.UpdateAdmin(al);
        }
    }
}
