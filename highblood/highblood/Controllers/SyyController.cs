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
    [ApiController]
    [Route("[controller]")]
    public class SyyController : ControllerBase
    {
        public readonly ISyyServices syyServices;
        public SyyController(ISyyServices syyServices)
        {
            this.syyServices = syyServices;
        }

        /// <summary>
        /// 查询syy表数据
        /// </summary>
        /// <returns></returns>

        [Route("/Syy/GetSyys")]
        [HttpGet]
        public List<syy> GetSyys()
        {
            return syyServices.GetSyys();
        }
    }
}
