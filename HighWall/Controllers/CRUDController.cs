using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighWall.DB.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighWall.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        private readonly MyDbContext _myDbContext;

        public CRUDController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        //https://localhost:44319/api/crud/tryRead
        [HttpGet("tryRead")]
        public ActionResult TryRead()
        {
            var myContext = _myDbContext;

            var queryable = myContext.User.Where(x=> x.ID == 1);

            foreach (var user in queryable)
            {
                Console.WriteLine(user.ID);
                Console.WriteLine(user.Name);
            }

            Console.WriteLine("HI");
            return null;

        }
    }
}