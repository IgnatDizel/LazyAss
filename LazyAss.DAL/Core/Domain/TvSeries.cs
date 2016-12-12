using System.Collections.Generic;

namespace LazyAss.DAL.Core.Domain
{
    public class TvSeries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRus { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string RatingKinopoisk { get; set; }
        public string RatingIMdb { get; set; }
        public int StartYearRelease { get; set; }
        public int? EndYearRelease { get; set; }
        public Status Status { get; set; }

        public virtual IList<GenresTvSeries> GenresTVseries { get; set; }
        public virtual IList<Image> Images { get; set; }
        public virtual IList<Season> Seasons { get; set; }
    }
}
