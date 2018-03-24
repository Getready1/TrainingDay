using Application.ManagerContracts;
using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ManagerImplementations
{
    public class ExerciseManager : IExerciseManager
    {
        private IExerciseRepository exerciseRepository;

        public ExerciseManager(IExerciseRepository exerciseRepository)
        {
            this.exerciseRepository = exerciseRepository;
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
