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
    class MichelinScraper : BaseScraper
    {
        public MichelinScraper(string url) : base(url)
        {
            this.selector_item = Properties.Settings.Default.michelin_selector_item;
            this.selector_title = Properties.Settings.Default.michelin_selector_title;
            this.selector_url = Properties.Settings.Default.michelin_selector_url;
            this.selector_rank = Properties.Settings.Default.michelin_selector_rank;
            this.limit = Properties.Settings.Default.michelin_limit;
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
            double rating = 0.1;
            var ratingElement = element.QuerySelector(Properties.Settings.Default.michelin_selector_rating);
            if (ratingElement != null)
            {
                var iconElements = ratingElement.QuerySelectorAll("svg.icon");
                if (iconElements.Count() == 1)
                {
                    // アイコン1つ
                    if (Regex.IsMatch(iconElements.ElementAt(0).ClassName, ".icon-etoile"))
                    {
                        // ★1
                        rating = 1;
                    }
                    else if (Regex.IsMatch(iconElements.ElementAt(0).ClassName, ".icon-assiette"))
                    {
                        // プレートアイコン
                        rating = 0.1;
                    }
                    else if (Regex.IsMatch(iconElements.ElementAt(0).ClassName, ".icon-bib-gourmand"))
                    {
                        // でぶちん
                        rating = 0.5;
                    }
                }
                else
                {
                    // アイコン複数の場合
                    var ratingCount = 0;
                    foreach(var icon in iconElements)
                    {
                        if (Regex.IsMatch(icon.ClassName, ".icon-etoile"))
                        {
                            ratingCount++;
                        }
                    }
                    rating = ratingCount;
                }
            }
            item.extraList.Add(rating.ToString());
        }

        protected override bool filter(ref Item item)
        {
            // 順位は要素数から判定
            item.rank = (this.crrItemIndex + 1).ToString();
            return true;
        }
    }
}
