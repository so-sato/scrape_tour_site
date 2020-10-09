using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Network.Default;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace ScrapeTool
{
    public class Item
    {
        public string rank;
        public string title;
        public string url;
        public List<string> extraList;

        public Item()
        {
            this.extraList = new List<string>();
        }

        public override string ToString()
        {
            List<string> outputList = new List<string>();
            outputList.Add(this.rank);
            outputList.Add(this.title);
            outputList.Add(this.url);
            if (this.extraList.Count > 0) outputList.AddRange(this.extraList);
            return string.Join("\t", outputList);
        }
    }

    abstract class BaseScraper
    {
        protected string url;
        protected int analyzeModerl = 1;
        protected string cityName;
        protected string cityCount;

        protected int crrPage;
        protected int crrItemIndex;
        protected List<string> errorMsgList;
        protected List<string> infoMsgList;

        protected string selector_item;
        protected string selector_title;
        protected string selector_url;
        protected string selector_rank;
        protected int limit;

        abstract protected string getNextPageUrl(IDocument document);

        public static BaseScraper factory(string url, int analyzeMode, int selectSite)
        {
            if (analyzeMode == 1)
            {
                Uri uri = new Uri(url);
                string hosts = uri.Authority;
                if (hosts.Contains(Properties.Settings.Default.HOSTS_TRIP) && (uri.PathAndQuery).ToLower().Contains("restaurants"))
                {
                    return new TripRestaurantScraper(url);
                }
                else if (hosts.StartsWith(Properties.Settings.Default.HOSTS_YELP))
                {
                    return new YelpScraper(url);
                }
                else if (hosts.Contains(Properties.Settings.Default.HOSTS_JALAN))
                {
                    return new JalanScraper(url);
                }
                else if (hosts.Contains(Properties.Settings.Default.HOSTS_4TRA))
                {
                    return new FortraScraper(url);
                }
                else if (hosts.Contains(Properties.Settings.Default.HOSTS_MICHELIN))
                {
                    return new MichelinScraper(url);
                }
            }
            else
            {
                if (selectSite == 0)
                {
                    return new FoursquareScraper(url);
                }
                else if (selectSite == 1)
                {
                    return new TripActivitiesScraper(url);
                }
                
            }
            
            return null;
        }

        protected BaseScraper(string url)
        {
            this.url = url;
            this.errorMsgList = new List<string>();
            this.infoMsgList = new List<string>();
            this.crrItemIndex = 0;
        }

        public virtual string checkParam(Dictionary<string, object> param)
        {
            return null;
        }

        public async Task<List<Item>> execute(Dictionary<string, object> param)
        {
            var resultList = new List<Item>();
            string msg = this.checkParam(param);
            if (msg != null) 
            {
                errorMsgList.Add(msg);
                return resultList;
            }
            // HTML取得
            crrPage = 0;
            await this.analyze(resultList, this.url);
            return resultList;
        }

        public string getErrMessage()
        {
            return string.Join("\r\n", this.errorMsgList.ToArray());
        }

        public string getInfoMessage()
        {
            return string.Join("\r\n", this.infoMsgList.ToArray());
        }

        protected IEnumerable<string> getValue(IDocument document, string selector)
        {
            var cells = document.QuerySelectorAll(selector);
            var textContents = cells.Select(m => Regex.Replace(m.TextContent, @"[\t]|[\n]|[\r\n]+", ""));
            return textContents;
        }

        protected IEnumerable<string> getHref(IDocument document, string selector)
        {
            var cells = document.QuerySelectorAll(selector);
            var textContents = cells.Select(m => ((IHtmlAnchorElement)m).Href);
            return textContents;
        }

        protected async Task<List<Item>> analyze(List<Item> resultList, string url)
        {
            crrPage++;

            IDocument document = null;
            if (analyzeModerl == 1)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var requester = new HttpRequester();
                requester.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36";
                var config = Configuration.Default.WithDefaultLoader(requesters: new[] { requester }).WithCookies().WithLocaleBasedEncoding();
                var context = BrowsingContext.New(config);
                document = await context.OpenAsync(url);
            }
            else
            {
                var config = Configuration.Default.WithJavaScript().WithCss();
                var parser = new HtmlParser(config);
                document = parser.Parse(url);
            }

            if (document.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                if (crrPage > 1)
                {
                    infoMsgList.Add("最終ページまで到達したため処理を中断しました。");
                }
                else
                {
                    infoMsgList.Add("存在しないページです");
                }
                return resultList;
            }

            var cells = document.QuerySelectorAll(selector_item);

            if (cells.Count() == 0)
            {
                errorMsgList.Add(crrPage + "ページ目：item要素の取得に失敗しました。");
                return resultList;
            }

            int inCount = resultList.Count;
            foreach(var element in cells)
            {
                var titleElement = element.QuerySelector(selector_title);
                var urlElement = element.QuerySelector(selector_url);
                var rankElements = element.QuerySelectorAll(selector_rank);

                if (titleElement == null
                    || urlElement == null)
                {
                    // title,urlが取得できない場合処理終了
                    errorMsgList.Add(crrPage + "ページ目：tile,url要素の取得に失敗しました。");
                    return resultList;
                }

                if (rankElements.Count() == 0) continue;
                var rankElement = rankElements.Last();

                var item = new Item();
                item.title = Regex.Replace(titleElement.TextContent, @"^[\s]+|[\s]+$|[\t]+|[\n]+|[\r\n]+", "");
                item.url = ((IHtmlAnchorElement)urlElement).Href;
                item.rank = Regex.Replace(rankElement.TextContent, @"[\s]+|[\t]+|[\n]+|[\r\n]+", "");
                this.getValueExtra(element, ref item);
                item = await this.addDetailAnalyze(item.url, item);

                if (!this.filter(ref item))
                {
                    continue;
                }
                resultList.Add(item);
                this.crrItemIndex = resultList.Count;

                if (resultList.Count >= limit) return resultList;
            }

            if (inCount == resultList.Count)
            {
                // 1ページ内で一つも取得できない場合終了
                infoMsgList.Add(crrPage + "ページ目：有効な要素が存在しないため処理を中断しました。");
                return resultList;
            }

            // 次ページのURLを取得
            var nextUrl = this.getNextPageUrl(document);
            if (nextUrl == null)
            {
                infoMsgList.Add("最終ページまで到達したため処理を中断しました。");
                return resultList;
            }

            await Task.Delay(3000);
            await this.analyze(resultList, nextUrl);

            return resultList;
        }

        protected virtual void getValueExtra(IElement element, ref Item item)
        {
            // 必要に応じてサブクラスで実装
        }

        #pragma warning disable 1998
        protected virtual async Task<Item> addDetailAnalyze(string url, Item item)
        {
            // 必要に応じてサブクラスで実装
            return item;
        }

        protected virtual bool filter(ref Item item)
        {
            // 必要に応じてサブクラスで実装
            return true;
        }
        
        protected virtual void execJavescript(IBrowsingContext context, IDocument document)
        {
            // 必要に応じてサブクラスで実装
        }

    }
}
