using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void ArticleAdd(Article article)
        {
            _articleDal.Insert(article);
        }

        public void ArticleDelete(Article article)
        {
            _articleDal.Delete(article);
        }

        public void ArticleUpdate(Article article)
        {
            _articleDal.Update(article);
        }

        public Article GetByID(int id)
        {
            return _articleDal.Get(x => x.ArticleId == id);
        }

        public List<Article> GetList()
        {
            return _articleDal.List();
        }
    }
}
