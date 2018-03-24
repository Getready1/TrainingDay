using DataModels;
using EntityFramework.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class SetRepository : BaseRepository<Set>, ISetRepository
    {
        public SetRepository(AppDataContext context) : base(context)
        {
        }

        public void Update(Set set) => context.Entry(set).State = EntityState.Modified;
    }
}
