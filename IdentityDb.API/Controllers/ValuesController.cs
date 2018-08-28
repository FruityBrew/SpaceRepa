using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityDb.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDb.API.Controllers
{
    [Produces("application/json")]
    [Route("api/values")]
    public class ValuesController : Controller
    {
        // POST api/values
        //[HttpPost]
        //public IActionResult AddUser(string login, String mail, Byte[] passHash)
        //{
        //    User user = new User
        //    {
        //        Login = login,
        //        Mail = mail,
        //        PassHash = passHash,
        //        RegistrationDt = DateTime.Now
        //    };

        //    try
        //    {
        //        UserActions._AddUser(user);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return BadRequest(e.Message);
        //    }

        //    return Ok();
        //}

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            try
            {
                UserActions._AddUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult AuthenticationUser(String login, Byte[] passHash)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(UserActions._GetUsers());
        }
    }
}
