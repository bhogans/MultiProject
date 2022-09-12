using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id); //Async(int id);
        Task<IEnumerable<T>> GetAll(); // Async();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression); //Async(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Upsert(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
