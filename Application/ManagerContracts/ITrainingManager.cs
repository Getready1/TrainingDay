using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ManagerContracts
{
    public interface ITrainingManager
    {
        List<Training> GetAll();
        void Add(Training training);
        void Delete(Training training);
        void Update(Training training);
        Training GetById(Guid id);
    }
}
