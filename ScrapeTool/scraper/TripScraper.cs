using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScrapeTool.scraper
{
    class TripScraper : BaseScraper
    {
        public TripScraper(string url) : base(url)
        {

        }

        protected override string getNextPageUrl(IDocument document)
        {
            string nextUrl = null;
            // 次ページのリンクがdisabledの場合次ページ取得しない
            if (document.QuerySelectorAll(Properties.Settings.Default.trip_next_element).Count() > 0)
            {
                return nextUrl;
            }
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
            var ratingElement = element.QuerySelector(Properties.Settings.Default.trip_rating);
            var reviewElement = element.QuerySelector(Properties.Settings.Default.trip_review_count);
            if (ratingElement.HasAttribute("alt"))
            {
                var alt = ratingElement.GetAttribute("alt");
                item.extraList.Add(Regex.Replace(Regex.Replace(alt, "バブル評価 5 段階中 ", ""), @"[ ]|[\t]|[\n]|[\r\n]+", ""));
            }
            else
            {
                item.extraList.Add("");
            }

            if (reviewElement != null)
            {
                item.extraList.Add(Regex.Replace(Regex.Replace(reviewElement.TextContent, "件の口コミ", ""), @"[ ]|[\t]|[\n]|[\r\n]+", ""));
            }
            else
            {
                item.extraList.Add("");
            }
        }

        protected override bool filter(ref Item item)
        {
            string regex = this.cityName + ".*" + this.cityCount;
            if (!Regex.IsMatch(item.rank, regex))
            {
                // 正規表現に一致しない場合対象外
                return false;
            }

            // 順位トリミング
            string[] separatingChars = { "：" };
            var rank_arr = item.rank.Split(separatingChars, StringSplitOptions.None);
            item.rank = rank_arr[0].Replace("位", "");

            return true;
        }

    }
}
