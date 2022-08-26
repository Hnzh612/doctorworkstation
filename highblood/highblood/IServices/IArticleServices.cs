using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public interface IArticleServices
    {
        public CallBack GetAllArticle(int page);
        public List<displayArticle> GetArticleByTitle(string title);
        public List<article> GrtArticleById(int id);
        public int AddArticle(Article article);
        //public int AddArticle();
        //public int DelArticle();
    }
}
