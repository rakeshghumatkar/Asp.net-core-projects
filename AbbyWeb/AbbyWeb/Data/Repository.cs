using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AbbyWeb.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext db;

        public DbSet<T> dbSet {get; set;}
        public Repository(ApplicationDbContext _db)
        {
            db = _db;
            dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
           IQueryable<T> query = dbSet;
           return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
           IQueryable<T> query = dbSet;
           query = query.Where(filter);
           return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}