using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HighWall.DB.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IQueryable<T> Read(Expression<Func<T,bool>> expression);
    }
}
