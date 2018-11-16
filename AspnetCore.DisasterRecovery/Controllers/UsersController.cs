using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore.DisasterRecovery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspnetCore.DisasterRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get([FromServices]DemoContext context)
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(
            [FromBody]User model,
            [FromServices]DemoContext context
        )
        {
            context.Users.Add(model);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
