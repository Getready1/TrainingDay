using DataModels;
using EntityFramework.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class TrainingRepository : BaseRepository<Training>, ITrainingRepository
    {
        public TrainingRepository(AppDataContext context) : base(context)
        {
        }

        public List<Training> GetAllTrainings()
        {
            return GetAll().Include(m => m.MuscleCategories).ThenInclude(mc => mc.MuscleCategory).Include(m => m.Exercises).ToList();
        }

        public void Update(Training training) => context.Entry(training).State = EntityState.Modified;
    }
}
