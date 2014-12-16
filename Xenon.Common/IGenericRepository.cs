using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Xenon.Common
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
    }
}
