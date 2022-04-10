using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using System.Configuration;

namespace MVC
{
    public static class GlobalVariables
    {
        public static string GetStringResponse(string FeedRequestUrl, string method)
        {
            HttpWebRequest feedRequest = (HttpWebRequest)WebRequest.Create(string.Concat(ConfigurationManager.AppSettings.Get("GraphFBDomain"), FeedRequestUrl));
            feedRequest.Method = method.ToUpper();
            feedRequest.Accept = "application/json";
            feedRequest.ContentType = "application/json; charset=utf-8";
            feedRequest.ContentLength = 0;

            WebResponse feedResponse = (HttpWebResponse)feedRequest.GetResponse();

            string data = "";

            using (feedResponse)
            {
                using (var reader = new StreamReader(feedResponse.GetResponseStream()))
                {
                    data = reader.ReadToEnd();
                }
            }
            return data;
        }

        public static string JsonResponse(string FeedRequestUrl, string method)
        {
            HttpWebRequest feedRequest = (HttpWebRequest)WebRequest.Create(string.Concat(ConfigurationManager.AppSettings.Get("LocalHostDomain"), FeedRequestUrl));
            feedRequest.Method = method.ToUpper();
            feedRequest.Accept = "application/json";
            feedRequest.ContentType = "application/json; charset=utf-8";
            feedRequest.ContentLength = 0;

            WebResponse feedResponse = (HttpWebResponse)feedRequest.GetResponse();

            string data = "";

            using (feedResponse)
            {
                using (var reader = new StreamReader(feedResponse.GetResponseStream()))
                {
                    data = reader.ReadToEnd();
                }
            }
            return data;
        }
    }
}