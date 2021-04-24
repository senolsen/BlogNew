using DataAccess.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void CategoryAdd(Category p)
        {
            if (p.CategoryName == null || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length>=51)
            {
                //Hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
