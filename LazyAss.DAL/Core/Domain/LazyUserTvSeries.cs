

namespace LazyAss.DAL.Core.Domain
{
    public class LazyUserTvSeries
    {
        public int LazyUserId { get; set; }
        public int TvSeriesId { get; set; }
        public int Id { get; set; }

        public virtual Episode Episode { get; set; }
        public virtual LazyUser LazyUser { get; set; }
    }
}
