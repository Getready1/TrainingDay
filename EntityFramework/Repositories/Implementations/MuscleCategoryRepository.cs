using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class MuscleCategoryRepository : BaseRepository<MuscleCategory>, IMuscleCategoryRepository
    {
        public MuscleCategoryRepository(AppDataContext context) : base(context)
        {
        }
    }
}
