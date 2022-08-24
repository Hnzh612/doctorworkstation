using highblood.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public class ArticleServices : IArticleServices
    {
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;port=3366;uid=root;pwd=123456 ;database=test",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        /// <summary>
        /// 返回所有文章信息
        /// </summary>
        /// <returns></returns>
        public List<displayArticle> GetAllArticle()
        {
            //return db.Queryable<article>().ToList();
            return db.Queryable<article, doctor>((a, d) => new JoinQueryInfos(JoinType.Left, a.DId == d.DId)).Select((a, d) => new displayArticle { AId = a.AId, DId = a.DId, DName = d.DName, DPhoto_Path = d.DPhoto_Path, AType = a.AType, ATitle = a.ATitle, AContent = a.AContent, ATime = a.ATime, APath = a.APath, AAgree = a.AAgree, ACollect = a.ACollect }).ToList();
            //return db.Queryable<article>().LeftJoin<doctor>((t, s) => t.DId == s.DId).Where(t => t.Title.Contains(title)).Select((t, s) => new Story { SId = s.SId, Content = s.Content, Pic = s.Pic, Date = s.Date, TId = s.TId }).ToList();
        }

        /// <summary>
        /// 根据标题查询文章信息
        /// </summary>
        /// <returns></returns>
        public List<displayArticle> GetArticleByTitle(string title)
        {
            return db.Queryable<article, doctor>((a, d) => new JoinQueryInfos(JoinType.Left, a.DId == d.DId)).Where(a => a.ATitle.Contains(title)).Select((a, d) => new displayArticle { AId = a.AId, DId = a.DId, DName = d.DName, DPhoto_Path = d.DPhoto_Path, AType = a.AType, ATitle = a.ATitle, AContent = a.AContent, ATime = a.ATime, APath = a.APath, AAgree = a.AAgree, ACollect = a.ACollect }).ToList();
            //return db.Queryable<article>().Where(it => it.ATitle.Contains(title)).ToList();
        }
    }
}
