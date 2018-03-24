using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace WebFacade.Services.Contracts
{
    public interface IExerciseService
    {
        List<Exercise> GetAll();
        void Add(Exercise exercise);
        void Delete(Exercise exercise);
        void Update(Exercise exercise);
        Training GetById(Exercise id);
    }
}
