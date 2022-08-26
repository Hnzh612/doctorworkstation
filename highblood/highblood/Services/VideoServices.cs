using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class VideoServices : Dbservice, IVideoServices
    {
        public VideoServices() : base()
        {

        }
        /// <summary>
        /// 返回所有视频信息
        /// </summary>
        /// <returns></returns>
        public List<video> GetAllVideo()
        {
            return db.Queryable<video>().ToList();
        }
    }
}
