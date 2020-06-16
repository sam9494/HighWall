using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using HighWall.DB.Context;
using Microsoft.EntityFrameworkCore;

namespace HighWall.DB.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        void Create(User entity);

        IQueryable<User> ReadById(int id);
    }

    public class UserRepository : IUserRepository 
    {
        private readonly MyDbContext _context;

        public DbSet<User> Context => this._context.Set<User>();

        public UserRepository(MyDbContext context)
        {
            _context = context;
        }


        public void Create(User entity)
        {
            Context.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<User> Read(Expression<Func<User, bool>> expression)
        {
            return Context.Where(expression);
        }

        public IQueryable<User> Read()
        {
            return null;
        }

        public IQueryable<User> ReadById(int id)
        {
            return Context.Where(x => x.ID == id);
        }
    }
}