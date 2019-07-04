using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var ratingElement = element.QuerySelector(Properties.Settings.Default.forsq_selector_rating);
            item.extraList.Add(ratingElement.TextContent);
        }

        protected override bool filter(ref Item item)
        {
            return true;
        }
        /*
        protected override async Task<System.Collections.Generic.IEnumerable<IDocument>> execJavescript(IBrowsingContext context, IDocument document)
        {

            IHtmlElement moreButton = (IHtmlElement)document.QuerySelector(".moreResults button");
            moreButton.DoClick();
            return document;
        }*/
    }
}
