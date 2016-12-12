
namespace LazyAss.DAL.Core.Domain
{
    public class GenresTvSeries
    {
        //public int TvSeriesId { get; set; }
        //public int GenresId { get; set; }
        public int Id { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual TvSeries TvSeries { get; set; }
    }
}
