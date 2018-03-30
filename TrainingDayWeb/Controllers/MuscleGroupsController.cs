using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainingDayWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/MuscleGroups")]
    public class MuscleGroupsController : Controller
    {
        // GET: api/MuscleGroups
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MuscleGroups/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/MuscleGroups
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/MuscleGroups/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
