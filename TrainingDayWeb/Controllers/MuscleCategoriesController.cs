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
    [Route("api/MuscleCategories")]
    public class MuscleCategoriesController : Controller
    {
        private AppDataContext context;

        public MuscleCategoriesController(AppDataContext context)
        {
            this.context = context;
        }
        // GET: api/MuscleCategories
        [HttpGet]
        public List<MuscleCategoryViewModel> Get()
        {
            var muscleCategories = context.MuscleCategories.ToList();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<MuscleCategory, MuscleCategoryViewModel>();
            });

            var muscleCategoriesVM = new List<MuscleCategoryViewModel>();
            muscleCategories.ForEach(mc => muscleCategoriesVM.Add(Mapper.Map<MuscleCategory, MuscleCategoryViewModel>(mc)));

            return muscleCategoriesVM;
        }

        // GET: api/MuscleCategories/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/MuscleCategories
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/MuscleCategories/5
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
