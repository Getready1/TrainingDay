using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Contracts
{
    public interface IExerciseRepository : IBaseRepository<Exercise>
    {
        void Update(Exercise exercise);
    }
}
