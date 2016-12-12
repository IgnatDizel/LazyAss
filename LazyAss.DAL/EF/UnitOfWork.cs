using LazyAss.DAL.Core;
using LazyAss.DAL.Core.Repositories;
using LazyAss.DAL.EF.Repositories;

namespace LazyAss.DAL.EF
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly LazyAssContext _context;

        public UnitOfWork(LazyAssContext context)
        {
            _context = context;
            TvSeries = new TvSeriesRepository(_context);
        }

        public ITvSeriesRepositories TvSeries { get; }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
