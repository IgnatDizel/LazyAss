using System.Collections.Generic;
using LazyAss.DAL.Core.Domain;

namespace LazyAss.DAL.Core.Repositories
{
    public interface ITvSeriesRepositories : IRepository<TvSeries>
    {
        IEnumerable<TvSeries> GetTvSeriesOnPage(int pageIndex, int pageSize);
    }
}
