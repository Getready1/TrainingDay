using Application.ManagerContracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using WebFacade.Services.Contracts;

namespace WebFacade.Services.Implementations
{
    public class ExerciesService : IExerciseService
    {
        private IExerciseManager exerciseManager;

        public ExerciesService(IExerciseManager exerciseManager)
        {
            this.exerciseManager = exerciseManager;
        }

        public void Add(Exercise exercise)
        {
            throw new NotImplementedException();
        }

        public void Delete(Exercise exercise)
        {
            throw new NotImplementedException();
        }

        public List<Exercise> GetAll()
        {
            throw new NotImplementedException();
        }

        public Training GetById(Exercise id)
        {
            throw new NotImplementedException();
        }

        public void Update(Exercise exercise)
        {
            throw new NotImplementedException();
        }
    }
}
