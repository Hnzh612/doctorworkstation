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
    public class BodydataController : ControllerBase
    {
        private readonly IBodydataServices _BodydataServices;

        public BodydataController(IBodydataServices BodydataServices)
        {
            _BodydataServices = BodydataServices;
        }
        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        [Route("/Bodydata/GetBodydata")]
        [HttpGet]
        public List<Bodydata> GetBodydata()
        {
            return _BodydataServices.GetBodydata();
        }

        /// <summary>
        /// 根据id返回数据
        /// </summary>
        /// <returns></returns>
        [Route("/Bodydata/GetBodydataById")]
        [HttpGet]
        public Bodydata GetIdUser(int id)
        {
            return _BodydataServices.GetIdBodydata(id);
        }
    }
}
