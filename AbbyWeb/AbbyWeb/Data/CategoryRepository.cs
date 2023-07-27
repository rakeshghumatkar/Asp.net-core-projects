using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyWeb.Data.IRepository;
using AbbyWeb.Models;

namespace AbbyWeb.Data
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext db ;

        public CategoryRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }
        public void Update(Category obj)
        {
            db.Categories.Update(obj);
        }
    }
}