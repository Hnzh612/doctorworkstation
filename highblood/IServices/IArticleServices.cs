using highblood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood.Services
{
    public interface IArticleServices
    {
        public List<displayArticle> GetAllArticle();
        public List<displayArticle> GetArticleByTitle(string title);
        //public int AddArticle();
        //public int DelArticle();
    }
}
