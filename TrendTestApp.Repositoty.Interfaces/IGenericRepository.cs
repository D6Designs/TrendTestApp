using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TrendTestApp.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> SelectAll { get; }
        IQueryable<T> SelectBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Save();
    }
}
