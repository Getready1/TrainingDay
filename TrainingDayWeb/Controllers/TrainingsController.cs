using System;
using System.Collections;
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
    [Route("api/trainings")]
    public class TrainingsController : Controller
    {
        private ITrainingManager trainingManager;
        private IMapper mapper;

        public TrainingsController(ITrainingManager trainingManager, IMapper mapper)
        {
            this.trainingManager = trainingManager;
            this.mapper = mapper;
        }

        // GET: api/Trainings
        [HttpGet]
        public IEnumerable<TrainingViewModel> Get()
        {
            var x = trainingManager.GetAll();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Training, TrainingViewModel>().ForMember(m => m.MuscleCategories, o => o.MapFrom(s => s.MuscleCategories.Select(r => r.MuscleCategory))).ForMember(v => v.Id, o => o.MapFrom(s => s.TrainingId));
                cfg.CreateMap<Exercise, ExerciseViewModel>()
                .ForMember(m => m.ExerciseId, o => o.MapFrom(z => z.ExerciseId))
                .ForMember(m => m.SupplimentaryMuscleGroups, o => o.MapFrom(s => s.SupplimentaryMuscleGroups.Select(r => r.MuscleGroup)))
                .ForMember(m => m.CoreMuscleGroups, o => o.MapFrom(s => s.CoreMuscleGroups.Select(r => r.MuscleGroup)));

                cfg.CreateMap<MuscleCategory, MuscleCategoryViewModel>().ForMember(m => m.Id, o => o.MapFrom(s => s.MuscleCategoryId));
                cfg.CreateMap<MuscleGroup, MuscleGroupViewModel>();
            });

            var collection = new List<TrainingViewModel>();

            foreach (var item in x)
            {
                collection.Add(Mapper.Map<Training, TrainingViewModel>(item));
            }


            return collection;
        }

        //// GET: api/Trainings/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/Trainings
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/Trainings/5
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
