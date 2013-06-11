using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesktopYoutube
{
    class Search
    {
        public void search()
        {
            // search method
        }

        private String generateURL(String keyword){
            // 元となるURL
            StringBuilder search_url = new StringBuilder("http://gdata.youtube.com/feeds/api/videos?q=");

            // query parameter
            search_url.Append(keyword);

            return search_url.ToString();
        }

        private List<String> getList() {
            
            
            return new List<string>();
        }

        // Youtube へパラメータを渡す
        private void sendRequest(String url) {
            var wr = (HttpWebRequest)WebRequest.Create(url);
            var res = wr.GetResponse();
            
        }


    }
}
