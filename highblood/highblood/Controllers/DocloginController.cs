using highblood.IServices;
using highblood.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocloginController : ControllerBase
    {
        private readonly IDocloginServices _DocloginServices;

        public DocloginController(IDocloginServices DoclginServices)
        {
            _DocloginServices = DoclginServices;
        }

        /// <summary>
        /// 返回所有医生登录
        /// </summary>
        /// <returns></returns>
        [Route("/Doclogin/GetDoclogin")]
        [HttpGet]
        public List<Doclogin> GetDoclogin()
        {
            return _DocloginServices.GetDoclogin();
        }
    }
}
