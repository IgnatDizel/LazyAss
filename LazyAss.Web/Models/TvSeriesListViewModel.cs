using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LazyAss.Web.Models
{
    public class TvSeriesListViewModel
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string NameRus { get; set; }
        public string ShortDescription { get; set; }
        public string SeasonCount { get; set; }
        public string Status { get; set; }
        public string Genres { get; set; }


        public static List<TvSeriesListViewModel> GetAllTvSeries()
        {
            var tvSeriesList = new List<TvSeriesListViewModel>();
            var tvSeriesAll = BLL.Managers.TvSeriesManager.GetAllSeries1();
            foreach (var tvSeries in tvSeriesAll)
            {
                tvSeriesList.Add(new TvSeriesListViewModel() {
                    Name = tvSeries.Name,
                    ImageUrl = tvSeries.Images.First().ImageUrl,
                    NameRus = tvSeries .NameRus,
                    SeasonCount = tvSeries.Seasons.Count.ToString(),
                    Status = tvSeries.Status.StatusStr,
                    ShortDescription = tvSeries .ShortDescription});
            }
            return tvSeriesList;
        } 
    }
}