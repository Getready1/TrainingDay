using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class MuscleGroupRepository : BaseRepository<MuscleGroup>, IMuscleGroupRepository
    {
        public MuscleGroupRepository(AppDataContext context) : base(context)
        {
        }
    }
}
