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
    public class ArticleController : ControllerBase
    {
        private readonly IArticleServices _articleServices;

        public ArticleController(IArticleServices articleServices)
        {
            _articleServices = articleServices;
        }

        /// <summary>
        /// 返回所有文章信息
        /// </summary>
        /// <returns></returns>
        [Route("/Articl/GetAllArticle")]
        [HttpGet]
        public CallBack GetAllArticle(int page)
        {
            return _articleServices.GetAllArticle(page);
        }

        /// <summary>
        /// 根据标题搜索文章信息
        /// </summary>
        /// <returns></returns>
        [Route("/Article/GetArticleByTitle")]
        [HttpGet]
        public List<displayArticle> GetArticleByTitle(string title)
        {
            return _articleServices.GetArticleByTitle(title);
        }

        /// <summary>
        /// 根据id获取文章信息
        /// </summary>
        /// <returns></returns>
        [Route("/Article/GrtArticleById")]
        [HttpGet]
        public List<article> AddArticle(int id)
        {
            return _articleServices.GrtArticleById(id);
        }

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <returns></returns>
        [Route("/Article/AddArticle")]
        [HttpPost]
        public int AddArticle(Article article)
        {
            return _articleServices.AddArticle(article);
        }
    }
}
