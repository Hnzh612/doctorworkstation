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
    public class userdynamicsController : ControllerBase
    {
        public readonly IuserdynamicsServices _userdynamicsServices;
        public userdynamicsController(IuserdynamicsServices userdynamicsServices)
        {
            this._userdynamicsServices = userdynamicsServices;
        }

        /// <summary>
        /// 查询syy表数据
        /// </summary>
        /// <returns></returns>

        [Route("/userdynamics/GetIuserdynamicsServices")]
        [HttpGet]
        public List<userdynamics> GetIuserdynamicsServices()
        {
            return _userdynamicsServices.GetIuserdynamicsServices();
        }
    }
}
