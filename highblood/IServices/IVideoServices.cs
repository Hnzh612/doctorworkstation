using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
     public interface IVideoServices
    {
            /// <summary>
            /// 返回所有视频信息
            /// </summary>
            /// <returns></returns>
            public List<displayVideo> GetAllVideo();
    }
}
