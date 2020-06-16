using System.Linq;
using HighWall.DB.Context;
using Microsoft.EntityFrameworkCore;

namespace HighWall.DB.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }

    public class UserRepository : IUserRepository 
    {
        private MyDbContext _context;

        public DbSet<User> Context => this._context.Set<User>();

        public UserRepository(MyDbContext context)
        {
            _context = context;
        }


        public void Create(User entity)
        {
            Context.Add(entity);
        }

        public IQueryable<User> Read()
        {
            throw new System.NotImplementedException();
        }
    }
}