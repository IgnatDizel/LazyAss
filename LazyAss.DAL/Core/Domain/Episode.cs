using System;
using System.Collections.Generic;

namespace LazyAss.DAL.Core.Domain
{
    public class Episode
    {
        public int Id { get; set; }
        //public int SeasonId { get; set; }
        public string Name { get; set; }
        public string NameRus { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int Number { get; set; }
        public int? CountEpisodes { get; set; }

        public virtual Season Season { get; set; }
        public virtual IList<LazyUserTvSeries> LazyUserTvSeries { get; set; }
    }
}
