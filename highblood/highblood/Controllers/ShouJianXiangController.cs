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
    public class ShouJianXiangController : ControllerBase
    {
        public readonly IShouJianXiangServices _sjxServices;
        public ShouJianXiangController(IShouJianXiangServices sjxServices)
        {
            this._sjxServices = sjxServices;
        }
        [Route("/SJX/GetMail")]
        [HttpGet]
        public List<ShouJianXiang> GetMail()
        {
            return _sjxServices.GetMail();
        }
    }
}
