using System.Collections.Generic;

namespace LazyAss.DAL.Core.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<GenresTvSeries> GenresTvSeries { get; set; }
    }
}
