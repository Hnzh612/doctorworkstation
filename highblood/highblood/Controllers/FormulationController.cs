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
    public class FormulationController : ControllerBase
    {
        public readonly IFormulationServices _FormulationServices;
        public FormulationController(IFormulationServices FormulationServices)
        {
            this._FormulationServices = FormulationServices;
        }

        /// <summary>
        /// 查询处方数据
        /// </summary>
        /// <returns></returns>

        [Route("/Formulation/GetFormulation")]
        [HttpGet]
        public List<Formulation> GetFormulation()
        {
            return _FormulationServices.GetFormulation();
        }

        [Route("/Formulation/GetFormulationById")]
        [HttpGet]
        public List<Formulation> GetIdFormulation(int id)
        {
            return _FormulationServices.GetIdFormulation(id);
        }
    }
}
