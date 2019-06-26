using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeTool
{
    class FortraScraper : BaseScraper
    {
        public FortraScraper(string url) : base(url)
        {
            this.selector_item = Properties.Settings.Default.fortra_selector_item;
            this.selector_title = Properties.Settings.Default.fortra_selector_title;
            this.selector_url = Properties.Settings.Default.fortra_selector_url;
            this.selector_rank = Properties.Settings.Default.fortra_selector_rank;
            this.limit = Properties.Settings.Default.fortra_limit;
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
            var reviewElement = element.QuerySelector(Properties.Settings.Default.fortra_selector_review);
            item.extraList.Add(System.Text.RegularExpressions.Regex.Replace(reviewElement.TextContent, @"[\t]|[\n]|[\r\n]+", ""));
        }

        protected override bool filter(ref Item item)
        {
            // 順位は要素数から判定
            item.rank = (this.crrItemIndex+1).ToString();

            return true;
        }
    }
}
