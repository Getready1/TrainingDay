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
    [Route("api/MuscleGroups")]
    public class MuscleGroupsController : Controller
    {
        private AppDataContext context;

        public MuscleGroupsController(AppDataContext context)
        {
            this.context = context;
        }

        // GET: api/MuscleGroups
        [HttpGet]
        public List<MuscleGroupViewModel> Get()
        {
            var mgroups = context.MuscleGroups.Include(x => x.MuscleCategory).ToList();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<MuscleGroup, MuscleGroupViewModel>().ForMember(x => x.MuscleCategoryId, o => o.MapFrom(y => y.MuscleCategoryId));
            });

            var mgroupsVM = new List<MuscleGroupViewModel>();
            mgroups.ForEach(mg => mgroupsVM.Add(Mapper.Map<MuscleGroup, MuscleGroupViewModel>(mg)));

            return mgroupsVM;
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
