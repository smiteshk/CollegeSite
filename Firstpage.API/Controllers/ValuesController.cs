using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firstpage.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firstpage.API.Controllers
{
    //http://localhost:5000/api/values
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //default Contructor.
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()//Asyncronous method.
        {
            //return new string[] { "value1", "value3" };
            var values= await _context.Values.ToListAsync();//go the values table and get the stored values and return as the list.
            return Ok(values);

        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValues(int id)
        {
            var value= await _context.Values.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
