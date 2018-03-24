using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ManagerContracts
{
    public interface IExerciseManager
    {
        List<Exercise> GetAll();
        void Add(Exercise exercise);
        void Delete(Exercise exercise);
        void Update(Exercise exercise);
        Training GetById(Exercise id);
    }
}
