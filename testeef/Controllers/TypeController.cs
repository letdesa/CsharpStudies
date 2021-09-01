using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeef.Data;
using testeef.Models;

namespace testeef.Controllers
{
    [ApiController]
    [Route("v1/types")]

    public class TypeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Type>>> Get([FromServices] DataContext context)
        {
            var types = await context.Types.ToListAsync();
            return types;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Type>> Post(
            [FromServices] DataContext context, 
            [FromBody] Type model)
        {
            if(ModelState.IsValid)
            {
                context.Types.Add(model);
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