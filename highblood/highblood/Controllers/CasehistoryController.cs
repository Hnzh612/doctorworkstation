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
    public class CasehistoryController : ControllerBase
    {
        private readonly ICasehistoryServices _CasehistoryServices;
        public CasehistoryController(ICasehistoryServices CasehistoryServices)
        {
            _CasehistoryServices = CasehistoryServices;
        }
        /// <summary>
        /// 返回所有病历信息
        /// </summary>
        /// <returns></returns>
        [Route("/Casehistory/GetCasehistory")]
        [HttpGet]
        public List<Casehistory> GetCasehistory()
        {
            return _CasehistoryServices.GetCasehistory();
        }
        /// <summary>
        /// 根据id返回数据
        /// </summary>
        /// <returns></returns>
        [Route("/Casehistory/GetCasehistoryById")]
        [HttpGet]
        public List<Casehistory> GetIdCase(int id)
        {
            return _CasehistoryServices.GetIdCase(id);
        }
    }
}
