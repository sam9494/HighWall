using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HighWall.DB.Context;
using HighWall.DB.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighWall.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public CRUDController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //https://localhost:44319/api/crud/tryRead
        [HttpGet("tryRead")]
        public ActionResult TryRead()
        {
            var queryable = _userRepository.Read(x=>x.ID==1);

            return new JsonResult(queryable);
            //return new JsonResult(readById);
        }

        //https://localhost:44319/api/crud/tryWrite
        [HttpGet("tryWrite")]
        public ActionResult TryWrite()
        {
            var user = new User
            {
                Name = "Sammm"
            };

            _userRepository.Create(user);
            return new JsonResult("ok");
        }
    }
}