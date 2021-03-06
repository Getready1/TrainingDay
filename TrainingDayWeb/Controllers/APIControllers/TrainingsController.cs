﻿using System;
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
            var trainings = trainingManager.GetAll();

            var vmTrainings = new List<TrainingViewModel>();

            foreach (var training in trainings)
            {
                vmTrainings.Add(Mapper.Map<Training, TrainingViewModel>(training));
            }

            return vmTrainings;
        }

        //// GET: api/Trainings/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Trainings
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
