using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Network.Default;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
            this.limit = Properties.Settings.Default.base_limit;
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

        protected override async Task<Item> addDetailAnalyze(string url, Item item)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var requester = new HttpRequester();
            requester.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36";
            var config = Configuration.Default.WithDefaultLoader(requesters: new[] { requester }).WithCookies().WithLocaleBasedEncoding();
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(url);

            var titleElement = document.QuerySelector(Properties.Settings.Default.fortra_selector_title_en);
            if (titleElement != null)
            {
                item.extraList.Add(Regex.Replace(titleElement.TextContent, @"^[\s]+|[\s]+$|[\t]+|[\n]+|[\r\n]+", ""));
            }
            await Task.Delay(1000);
            return item;
        }
    }
}
