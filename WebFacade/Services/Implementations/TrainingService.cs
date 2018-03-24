using Application.ManagerContracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using WebFacade.Services.Contracts;

namespace WebFacade.Services.Implementations
{
    public class TrainingService : ITrainingService
    {
        private ITrainingManager trainingManager;

        public TrainingService(ITrainingManager trainingManager)
        {
            this.trainingManager = trainingManager;
        }

        public void Add(Training training)
        {
            throw new NotImplementedException();
        }

        public void Delete(Training training)
        {
            throw new NotImplementedException();
        }

        public List<Training> GetAll()
        {
            throw new NotImplementedException();
        }

        public Training GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
