using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Contracts
{
    public interface ITrainingRepository : IBaseRepository<Training>
    {
        void Update(Training training);
        List<Training> GetAllTrainings();
    }
}
