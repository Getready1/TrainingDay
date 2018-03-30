using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ManagerContracts;
using AutoMapper;
using DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace TrainingDayWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/exercises")]
    public class ExercisesController : Controller
    {
        private IExerciseManager exerciseManager;

        public ExercisesController(IExerciseManager exerciseManager)
        {
            this.exerciseManager = exerciseManager;
        }

        // GET: api/Exercises
        [HttpGet]
        public IEnumerable<ExerciseViewModel> Get()
        {
            var x = exerciseManager.GetAll();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Exercise, ExerciseViewModel>();
            });

            var collection = new List<ExerciseViewModel>();

            foreach (var item in x)
            {
                collection.Add(Mapper.Map<Exercise, ExerciseViewModel>(item));
            }

            return collection;
        }

        //// GET: api/Exercises/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/Exercises
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/Exercises/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
