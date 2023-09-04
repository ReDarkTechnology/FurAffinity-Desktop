using Microsoft.Web.WebView2.WinForms;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace FurAffinity
{
    public static class FAScraper
    {
        public const string tosUrl = "https://www.furaffinity.net/tos";
        public static WebView2 webView;
        public static System.Action<string> onLoadedFinish;
        
        public static void SetView(WebView2 webView)
        {
            FAScraper.webView = webView;
            webView.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
        }

        private static async void CoreWebView2_DOMContentLoaded(object sender, Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs e)
        {
            System.Console.WriteLine("SNADJKHNAJFS");
            onLoadedFinish.Invoke(await GetHtmlFromBrowser());
        }

        public static async Task<string> GetHtmlFromBrowser()
        {
            var task = webView.CoreWebView2.ExecuteScriptAsync("document.body.outerHTML");
            var html = await task;
            return JsonConvert.DeserializeObject(html).ToString();
        }
    }

    public class FAHTTPResponse
    {
        public bool isContentFetched;
        public string content;
        public HttpResponseMessage message;

        public FAHTTPResponse() { }
        public FAHTTPResponse(bool error, string text, HttpResponseMessage msg)
        {
            isContentFetched = error;
            content = text;
            message = msg;
        }
    }
}
