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

        public override string checkParam(Dictionary<string, object> param)
        {
            if (param.ContainsKey("city_name") && param["city_name"] != null && !param["city_name"].ToString().Equals(""))
            {
                this.cityName = param["city_name"].ToString();
            }
            else
            {
                return "トリップアドバイザーの場合都市名は必須です。";
            }
            if (param.ContainsKey("city_count") && param["city_count"] != null && !param["city_count"].ToString().Equals(""))
            {
                this.cityCount = param["city_count"].ToString();
            }
            else
            {
                return "トリップアドバイザーの場合分母数は必須です。";
            }
            return null;
        }
    }
}
