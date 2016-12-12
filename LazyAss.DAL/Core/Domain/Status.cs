using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyAss.DAL.Core.Domain
{
    public class Status
    {
        public int Id { get; set; }
        public string StatusStr { get; set; }

        public virtual IList<TvSeries> StatusTvSeries { get; set; }
    }
}
