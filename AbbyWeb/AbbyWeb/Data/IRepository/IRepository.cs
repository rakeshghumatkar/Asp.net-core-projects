using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AbbyWeb.Data.IRepository
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();

        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        
        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}