using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ngWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthorController : ControllerBase
    {
        public readonly ngApiDBContext context = new ngApiDBContext();

        [HttpGet]
        public IEnumerable<User> Get()
        {

            //var UpdateAuthor1 = context.Authors.Where(a => a.AuthorId == 1).FirstOrDefault();
            ////UpdateAuthor1.FirstName = "Abraham4201";
            //context.Remove(UpdateAuthor1);
            //context.SaveChanges();
            return context.Users.ToList();

        }

        [HttpGet]
        public IActionResult getUserDetails()
        {
            var data = context.Users.Where(x => x.JobId == 13).FirstOrDefault();

            return Ok(data);
        }

        [HttpPost]
        public IActionResult saveUserDetails(User userModel) 
        {
            userModel.HireDate = DateTime.Now;
            context.Add(userModel);

            context.SaveChanges();
            return Ok();
        }

    }
}
