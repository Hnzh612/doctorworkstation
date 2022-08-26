using highblood.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            ConnectionString = "server=localhost;port=3306;uid=root;pwd=123456;database=test;charset=utf8mb4;",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true
        });
        /// <summary>
        /// 返回所有文章信息
        /// </summary>
        /// <returns></returns>
        public CallBack GetAllArticle(int page)
        {
            CallBack callBack = new CallBack();
            callBack.message = db.Ado.GetInt("select count(1) from article").ToString();
            callBack.data = db.Queryable<article>().OrderBy(it => it.ATime, OrderByType.Desc).ToPageList(page, 10).ToList();
            return callBack;
            //return db.Queryable<article>().LeftJoin<doctor>((t, s) => t.DId == s.DId).Where(t => t.Title.Contains(title)).Select((t, s) => new Story { SId = s.SId, Content = s.Content, Pic = s.Pic, Date = s.Date, TId = s.TId }).ToList();
        }

        /// <summary>
        /// 根据标题查询文章信息
        /// </summary>
        /// <returns></returns>
        public List<displayArticle> GetArticleByTitle(string title)
        {
            return db.Queryable<article, doctor>((a, d) => new JoinQueryInfos(JoinType.Left, a.DId == d.DId)).Where(a => a.ATitle.Contains(title)).Select((a, d) => new displayArticle { AId = a.AId, DId = a.DId, DName = d.DName, DPhoto_Path = d.DPhoto_Path, AType = a.AType, ATitle = a.ATitle, AContent = a.AContent, ATime = a.ATime, ALength = a.ALength, AAgree = a.AAgree, ACollect = a.ACollect }).ToList();
            //return db.Queryable<article>().Where(it => it.ATitle.Contains(title)).ToList();
        }

        /// <summary>
        /// 根据id获取文章信息
        /// </summary>
        /// <returns></returns>
        public List<article> GrtArticleById(int id)
        {
            return db.Queryable<article>().Where(it=>it.AId == id).ToList();
        }

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <returns></returns>
        public int AddArticle(Article article)
        {
            if(article.AId > 0 )
            {
                return db.Updateable(article).Where(it => it.AId == article.AId).ExecuteCommand();
            }
            else
            {
            return db.Insertable(article).ExecuteCommand();
            }
        }

    }
}
