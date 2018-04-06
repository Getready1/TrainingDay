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
    [Route("api/ExerciseTemplates")]
    public class ExerciseTemplatesController : Controller
    {
        private AppDataContext context;

        public ExerciseTemplatesController(AppDataContext context)
        {
            this.context = context;
        }
        // GET: api/ExerciseTemplates
        [HttpGet]
        public List<ExerciseTemplateViewModel> Get()
        {
            var templates = context.ExerciseTemplates
                .Include(x => x.CoreMuscleGroups).ThenInclude(y => y.MuscleGroup)
                .Include(x => x.SupplimentaryMuscleGroups)
                .ToList();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<MuscleGroup, MuscleGroupViewModel>();
                cfg.CreateMap<ExerciseTemplate, ExerciseTemplateViewModel>()
                .ForMember(x => x.CoreMuscleGroups, y => y.MapFrom(z => z.CoreMuscleGroups.Select(w => w.MuscleGroup)))
                .ForMember(x => x.SupplimentaryMuscleGroups, y => y.MapFrom(z => z.SupplimentaryMuscleGroups.Select(w => w.MuscleGroup)))
                .ForMember(x => x.Metrics, y => y.MapFrom(z => z.Metrics.Select(w => w.Metric)));
            });
            var mappedCollection = new List<ExerciseTemplateViewModel>();
            templates.ForEach(template => mappedCollection.Add(Mapper.Map<ExerciseTemplate, ExerciseTemplateViewModel>(template)));

            return mappedCollection;
        }

        // GET: api/ExerciseTemplates/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/ExerciseTemplates
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/ExerciseTemplates/5
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
