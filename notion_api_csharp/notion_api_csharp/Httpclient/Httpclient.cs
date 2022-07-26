using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace notion_api_csharp.Httpclient
{
    public class Notionhttpclient
    {
        public HttpWebRequest client;
        //Httpclient类的实际http请求
        private HttpWebRequest httpRequest;
        //Httpclient类的httpRequest的请求地址
        private const string _baseurl = "https://api.notion.com/v1/";

        private readonly string _url;

        private readonly string _type;

        private readonly string _Accept = "application/json";

        private readonly string _NotionVersion = "2022-06-28";

        private readonly string _Authorization;
        public Notionhttpclient(string id, string type, string Accept, string NotionVersion, string Authorization)
        {
            _url = _baseurl + type + "/" + id;
            _Accept = Accept;
            _NotionVersion = NotionVersion;
            _Authorization = Authorization;
            client = CreateNotionHttpClient();
        }

        public Notionhttpclient(string id, string type, string Authorization)
        {
            _url = _baseurl + type + "/" + id;
            _Authorization = Authorization;
            client = CreateNotionHttpClient();
        }

        private HttpWebRequest CreateNotionHttpClient()
        {
            httpRequest = (HttpWebRequest)WebRequest.Create(_url);
            httpRequest.Accept = _Accept;
            httpRequest.Headers["Notion-Version"] = _NotionVersion;
            httpRequest.Headers["Authorization"] = "Bearer" + " " + _Authorization;
            return httpRequest;
        }
    }
}
