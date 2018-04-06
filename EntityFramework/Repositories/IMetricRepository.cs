using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories
{
    public interface IMetricRepository : IBaseRepository<Metric>
    {
    }
}
