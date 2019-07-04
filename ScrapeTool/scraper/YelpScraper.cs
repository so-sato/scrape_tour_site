using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScrapeTool
{
    class YelpScraper : BaseScraper
    {
        public YelpScraper(string url) : base(url)
        {
            this.selector_item = Properties.Settings.Default.yelp_selector_item;
            this.selector_title = Properties.Settings.Default.yelp_selector_title;
            this.selector_url = Properties.Settings.Default.yelp_selector_url;
            this.selector_rank = Properties.Settings.Default.yelp_selector_rank;
            this.limit = Properties.Settings.Default.yelp_limit;
        }

        protected override string getNextPageUrl(IDocument document)
        {
            string nextUrl = null;
            var cells = document.QuerySelectorAll("html head link[rel='next']");
            var textContents = cells.Select(m => ((IHtmlLinkElement)m).Href);
            if (textContents.Count() > 0)
            {
                nextUrl = textContents.ElementAt(0);
            }
            return nextUrl;
        }

        protected override void getValueExtra(IElement element, ref Item item)
        {
            var ratingElement = element.QuerySelector(Properties.Settings.Default.yelp_rating);
            var alt = ratingElement.GetAttribute("aria-label");
            item.extraList.Add(Regex.Replace(Regex.Replace(alt, "つ星評価", ""), @"[ ]|[\t]|[\n]|[\r\n]+", ""));
        }

        protected override bool filter(ref Item item)
        {
            // 広告要素除去
            if (Regex.IsMatch(item.url, "ad_business_id", RegexOptions.Singleline))
            {
                return false;
            }

            // 順位トリミング
            string[] separatingChars = { "." };
            var rank_arr = item.rank.Split(separatingChars, StringSplitOptions.None);
            item.rank = rank_arr[0];

            return true;
        }

    }
}
