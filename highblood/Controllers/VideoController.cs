using highblood.Model;
using highblood.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly IVideoServices _videoServices;

        public VideoController(IVideoServices videoServices)
        {
            _videoServices = videoServices;
        }

        /// <summary>
        /// 返回所有视频信息
        /// </summary>
        /// <returns></returns>
        [Route("/Video/GetAllVideo")]
        [HttpGet]
        public List<displayVideo> GetAllVideo()
        {
            return _videoServices.GetAllVideo();
        }
    }
}
