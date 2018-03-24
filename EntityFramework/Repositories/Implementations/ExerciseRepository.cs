using DataModels;
using EntityFramework.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(AppDataContext context) : base(context)
        {
        }

        public void Update(Exercise exercise) => context.Entry(exercise).State = EntityState.Modified;
    }
}
