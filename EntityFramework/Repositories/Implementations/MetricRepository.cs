using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Repositories.Implementations
{
    public class MetricRepository : BaseRepository<Metric>, IMetricRepository
    {
        public MetricRepository(AppDataContext context) : base(context)
        {
        }
    }
}
