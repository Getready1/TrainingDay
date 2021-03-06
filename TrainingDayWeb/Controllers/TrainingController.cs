﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ManagerContracts;
using AutoMapper;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace TrainingDayWeb.Controllers
{
    public class TrainingController : Controller
    {
        private ITrainingManager trainingManager;

        public TrainingController(ITrainingManager trainingManager)
        {
            this.trainingManager = trainingManager;
        }

        public IActionResult Index()
        {
            var trainings = trainingManager.GetAll();
            //Mapper.Initialize(cfg => cfg.CreateMap<Training, TrainingViewModel>().ForMember(m => m.MuscleCategories, o => o.MapFrom(s => s.MuscleCategories.Select(r => r.MuscleCategory))));
            var collection = new List<TrainingViewModel>();

            foreach (var item in trainings)
            {
                collection.Add(Mapper.Map<Training, TrainingViewModel>(item));
            }

            return View(collection);
        }

        // GET: Training/Create
        public IActionResult Create()
        {
            return View(new TrainingViewModel { CreationDate = DateTime.UtcNow });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TrainingViewModel trainingVM)
        {
            if (ModelState.IsValid)
            {
                trainingManager.Add(Mapper.Map<TrainingViewModel, Training>(trainingVM));
                return RedirectToAction(nameof(Index));
            }
            return View(trainingVM);
        }
    }
}