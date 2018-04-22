using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataModels;
using EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModels;

namespace TrainingDayWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Sets")]
    public class SetsController : Controller
    {
        private AppDataContext context;

        public SetsController(AppDataContext context)
        {
            this.context = context;
        }

        // GET: api/Sets
        [HttpGet]
        public List<SetViewModel> Get()
        {
            return null;
        }

        // GET: api/Sets/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Sets
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Sets/5
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
