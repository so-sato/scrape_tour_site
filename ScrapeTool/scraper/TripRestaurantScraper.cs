using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using ScrapeTool.scraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeTool
{
    class TripRestaurantScraper : TripScraper
    {
        public TripRestaurantScraper(string url) : base(url)
        {
            this.selector_item = Properties.Settings.Default.trip_selector_item;
            this.selector_title = Properties.Settings.Default.trip_restaurant_selector_title;
            this.selector_url = Properties.Settings.Default.trip_restaurant_selector_url;
            this.selector_rank = Properties.Settings.Default.trip_restaurant_selector_rank;
            this.limit = Properties.Settings.Default.trip_limit;
        }
    }
}
