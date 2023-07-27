using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyWeb.Models;

namespace AbbyWeb.Data.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public void Update(Category obj);
    }
}