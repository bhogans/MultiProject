using CleanUp.Data.SqlServer.Interfaces;
using CleanUp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Data.SqlServer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        //internal DbSet<T> dbSet;
        //public readonly ILogger _logger;

        public GenericRepository(ApplicationDbContext context)//, ILogger logger)
        {
            _context = context;
            //dbSet = context.Set<T>();
            //_logger = logger;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        //public async Task<T> GetByIdAsync(int id)
        //{
        //    return await _context.Set<T>().FindAsync(id);
        //}
        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Upsert(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
