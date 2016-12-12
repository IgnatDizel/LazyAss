using System.Collections.Generic;
using System.Linq;
using LazyAss.DAL.Core.Domain;
using LazyAss.DAL.Core.Repositories;

namespace LazyAss.DAL.EF.Repositories
{
    public class TvSeriesRepository : Repository<TvSeries>, ITvSeriesRepositories
    {
        public TvSeriesRepository(LazyAssContext context) 
            : base(context)
        {
        }

        public IEnumerable<TvSeries> GetTvSeriesOnPage(int pageIndex, int pageSize = 10)
        {
            return LazyAssContext.TvSeries
                .Skip((pageIndex - 1)*pageSize)
                .Take(pageSize)
                .ToList();
        }

        public LazyAssContext LazyAssContext
        {
            get { return Context as LazyAssContext; }
        }
    }
}
