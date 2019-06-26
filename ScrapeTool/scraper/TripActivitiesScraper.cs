using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using ScrapeTool.scraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace ScrapeTool
{
    class TripActivitiesScraper : TripScraper
    {
        public TripActivitiesScraper(string url) : base(url)
        {
            this.selector_item = Properties.Settings.Default.trip_selector_item;
            this.selector_title = Properties.Settings.Default.trip_activities_selector_title;
            this.selector_url = Properties.Settings.Default.trip_activities_selector_url;
            this.selector_rank = Properties.Settings.Default.trip_activities_selector_rank;
            this.limit = Properties.Settings.Default.trip_limit;
        }
    }
}
