using System;
using System.Collections.Generic;

namespace LazyAss.DAL.Core.Domain
{
    public class Season
    {
        public int Id { get; set; }
        //public int TvSeriesId { get; set; }
        public DateTime? StartDate { get; set; }
        public int SeasonNumber { get; set; }

        public virtual IList<Episode> Episodes { get; set; }
        public virtual TvSeries TvSeries { get; set; }
    }
}
