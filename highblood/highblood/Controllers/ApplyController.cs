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
    public class ApplyController : ControllerBase
    {
        private readonly IApplyServices _ApplyServices;

        public ApplyController(IApplyServices ApplyServices)
        {
            _ApplyServices = ApplyServices;
        }

        /// <summary>
        /// 返回所有病历信息
        /// </summary>
        /// <returns></returns>
        [Route("/Apply/GetApply")]
        [HttpGet]
        public List<Apply> GetApply()
        {
            return _ApplyServices.GetApply();
        }
    }
}
