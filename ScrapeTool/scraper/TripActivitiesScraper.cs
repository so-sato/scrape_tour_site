using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using ScrapeTool.scraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace ScrapeTool
{
    class TripActivitiesScraper : TripScraper
    {
        protected int mode = 0;
        public TripActivitiesScraper(string url) : base(url)
        {
            // 1ページ目と2ページ目以降でHTML構造が異なるため検証
            var config = Configuration.Default.WithJavaScript().WithCss();
            var parser = new HtmlParser(config);
            var document = parser.Parse(url);

            var cell = document.QuerySelector("html head link[rel='prev']");
            if (cell == null)
            {
                // 1ページ目
                mode = 1;
                this.selector_item = Properties.Settings.Default.trip_activities_selector_item_fst;
                this.selector_title = Properties.Settings.Default.trip_activities_selector_title_fst;
                this.selector_url = Properties.Settings.Default.trip_activities_selector_url_fst;
                this.selector_rank = Properties.Settings.Default.trip_activities_selector_rank_fst;
            }
            else
            {
                mode = 2;
                this.selector_item = Properties.Settings.Default.trip_selector_item;
                this.selector_title = Properties.Settings.Default.trip_activities_selector_title;
                this.selector_url = Properties.Settings.Default.trip_activities_selector_url;
                this.selector_rank = Properties.Settings.Default.trip_activities_selector_rank;
            }
            this.limit = Properties.Settings.Default.trip_limit;

            analyzeModerl = 2;
        }

        protected override string getNextPageUrl(IDocument document)
        {
            return null;
        }

        protected override void getValueExtra(IElement element, ref Item item)
        {
            if (mode == 2)
            {
                base.getValueExtra(element, ref item);
                return;
            }
            var ratingElement = element.QuerySelector(Properties.Settings.Default.trip_activities_selector_rank_fst);
            var reviewElement = element.QuerySelector(Properties.Settings.Default.trip_activities_selector_review_count_fst);

            if (ratingElement.HasAttribute("title"))
            {
                var alt = ratingElement.GetAttribute("title");
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
            item.url = Regex.Replace(item.url, @"^about:\/\/", "https://www.tripadvisor.jp");

            if (mode == 1)
            {
                // 順位は要素数から判定
                item.rank = (this.crrItemIndex + 1).ToString();
            } 
            else
            {
                // 順位トリミング
                string[] separatingChars = { "位：" };
                var rank_arr = item.rank.Split(separatingChars, StringSplitOptions.None);
                item.rank = rank_arr[0];
            }
            return true;
        }
    }
}
