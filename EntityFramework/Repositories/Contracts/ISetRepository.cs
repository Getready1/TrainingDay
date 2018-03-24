using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Contracts
{
    public interface ISetRepository : IBaseRepository<Set>
    {
        void Update(Set set);
    }
}
