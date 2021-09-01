using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeef.Data;
using testeef.Models;

namespace testeef.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<User>>> Get([FromServices] DataContext context)
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<User>> GetById([FromServices] DataContext context, int id)
        {
            var user = await context.Users
                .Include(x => x.Type)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        [HttpGet]
        [Route("types/{id:int}")]
         public async Task<ActionResult<List<User>>> GetByType([FromServices] DataContext context, int id)
        {
            var users = await context.Users
                .Include(x => x.Type)
                .AsNoTracking()
                .Where(x => x.TypeId == id)
                .ToListAsync();
            return users;
        }

        [HttpPost]
        [Route("")]
         public async Task<ActionResult<User>> Post(
             [FromServices] DataContext context,
             [FromBody]User model)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }

}