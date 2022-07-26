using notion_api_csharp.Httpclient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace notion_api_csharp.Databases
{
    public class DatabaseRetrieve
    {
        private readonly string _databaseid;

        private readonly string _type;

        private readonly string _token;

        private readonly Notionhttpclient notionhttpclient;

        private HttpWebResponse httpResponse;

        public DatabaseRetrieve(string databaseid, string type, string token)
        {
            _databaseid = databaseid;
            _type = type;
            _token = token;
            notionhttpclient = new Notionhttpclient(databaseid, type, token);
        }

        public string Get()
        {
            httpResponse = (HttpWebResponse)notionhttpclient.client.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
