using System;
using LazyAss.DAL.Core.Repositories;

namespace LazyAss.DAL.Core
{
    public interface IUnitOfWork : IDisposable
    {
            ITvSeriesRepositories TvSeries { get; }
            void Complete();
    }
}
