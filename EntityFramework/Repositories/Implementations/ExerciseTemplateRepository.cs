using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class ExerciseTemplateRepository : BaseRepository<ExerciseTemplate>, IExerciseTemplateRepository
    {
        public ExerciseTemplateRepository(AppDataContext context) : base(context)
        {
        }
    }
}
