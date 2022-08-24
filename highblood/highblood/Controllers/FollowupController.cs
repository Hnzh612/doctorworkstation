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
    public class FollowupController : ControllerBase
    {
        public readonly IFollowupServices _FollowupServices;
        public FollowupController(IFollowupServices FollowupServices)
        {
            this._FollowupServices = FollowupServices;
        }
        [Route("/Followup/GetFollowup")]
        [HttpGet]
        public List<Followup> GetMail()
        {
            return _FollowupServices.GetFollowup();
        }
    }
}
