using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class VideoServices : IVideoServices
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3366;uid=root;pwd=123456 ;database=test",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        /// <summary>
        /// 返回所有视频信息
        /// </summary>
        /// <returns></returns>
        public List<displayVideo> GetAllVideo()
        {
            return db.Queryable<video, doctor>((v, d) => new JoinQueryInfos(JoinType.Left, v.DId == d.DId)).Select((v, d) => new displayVideo { VId = v.VId, VPhoto_Path = v.VPhoto_Path, DId = v.DId, DName = d.DName, DPhoto_Path = d.DPhoto_Path, VTitle = v.VTitle, VTime = v.VTime}).ToList();
           
        }
    }
}
