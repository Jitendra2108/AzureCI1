using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
   public class ValueController  : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2","Bhawesh" };
        }

        // GET: api/values/5
        [HttpGet("{id}")]        
        public ActionResult<string> Get(int id)
        {
            return "Bhawesh Paliwal";
        }

        // POST: api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
        
    }

}