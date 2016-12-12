
namespace LazyAss.DAL.Core.Domain
{
    public class Image
    {
        public int Id { get; set; }
        //public int TvSeriesId { get; set; }
        public string ImageUrl { get; set; }

        public virtual TvSeries TvSeries { get; set; }
    }
}
