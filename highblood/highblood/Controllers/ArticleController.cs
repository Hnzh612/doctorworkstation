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
        public List<displayArticle> GetAllArticle()
        {
            return _articleServices.GetAllArticle();
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
    }
}
