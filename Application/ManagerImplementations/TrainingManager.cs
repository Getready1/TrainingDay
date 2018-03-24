using Application.ManagerContracts;
using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ManagerImplementations
{
    public class TrainingManager : ITrainingManager
    {
        private ITrainingRepository trainingRepository;

        public TrainingManager(ITrainingRepository trainingRepository)
        {
            this.trainingRepository = trainingRepository;
        }

        public void Add(Training training)
        {
            trainingRepository.Add(training);
        }

        public void Delete(Training training)
        {
            trainingRepository.Delete(training);
        }

        public List<Training> GetAll()
        {
            return trainingRepository.GetAllTrainings();
        }

        public Training GetById(Guid id)
        {
            return trainingRepository.GetById(id);
        }

        public void Update(Training training)
        {
            trainingRepository.Update(training);
        }
    }
}
