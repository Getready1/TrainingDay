using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace WebFacade.Services.Contracts
{
    public interface ITrainingService
    {
        List<Training> GetAll();
        void Add(Training training);
        void Delete(Training training);
        void Update(Training training);
        Training GetById(Guid id);
    }
}
