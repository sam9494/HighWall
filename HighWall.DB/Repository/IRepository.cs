using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighWall.DB.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IQueryable<T> Read();
    }
}
