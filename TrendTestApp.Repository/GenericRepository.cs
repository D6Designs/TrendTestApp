using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.EntityModel;
using TrendTestApp.Repository.Interfaces;

namespace TrendTestApp.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class

    {

        


        protected readonly TrendEntities DataContext;

        protected GenericRepository(IDataContext ctx)
        {
            DataContext = ctx._dataContext;
        }


        public virtual IQueryable<T> SelectAll
        {
            get
            {

                IQueryable<T> query = DataContext.Set<T>();
                return query;
            }
        }

        public virtual IQueryable<T> SelectBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = DataContext.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            DataContext.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            DataContext.Set<T>().Remove(entity);
        }


        public virtual void Save()
        {
            DataContext.SaveChanges();
        }

    }
}
