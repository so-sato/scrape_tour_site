using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Extensions;
using AngleSharp.Network.Default;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScrapeTool
{
    class FoursquareScraper : BaseScraper
    {
        public FoursquareScraper(string url) : base(url)
        {
            this.selector_item = Properties.Settings.Default.forsq_selector_item;
            this.selector_title = Properties.Settings.Default.forsq_selector_title;
            this.selector_url = Properties.Settings.Default.forsq_selector_url;
            this.selector_rank = Properties.Settings.Default.forsq_selector_rank;
            this.limit = Properties.Settings.Default.base_limit;

            analyzeModerl = 2;
        }

        protected override string getNextPageUrl(IDocument document)
        {
            return null;
        }

        protected override void getValueExtra(IElement element, ref Item item)
        {
            var ratingElement = element.QuerySelector(Properties.Settings.Default.forsq_selector_rating);
            item.extraList.Add(Regex.Replace(ratingElement.TextContent, @"\?|[\t]|[\n]|[\r\n]+", ""));
        }

        protected override bool filter(ref Item item)
        {
            item.url = Regex.Replace(item.url, @"^about:\/\/", "https://ja.foursquare.com");
            if (item.rank.Equals("?"))
            {
                item.rank = "";
            }
            return true;
        }
    }
}
