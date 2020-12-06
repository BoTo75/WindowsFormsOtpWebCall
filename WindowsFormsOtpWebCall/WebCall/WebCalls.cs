using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOtpWebCall.WebCall
{
    public class WebCalls
    {
        private static string _url;

        public WebCalls()
        { 
        }

        public WebCalls(string url)
        {
            _url = url;
        }

        public static void SetUrl(string url)
        {
            _url = url;
        }

        public static string GetUrl()
        {
            return _url;
        }


        public Dictionary<string, string> PostFile(File_info[] requestObj)
        {              
            Dictionary<string, string> responseObj = new Dictionary<string, string>();
            using (var client = new HttpClient())
            {                             
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = new HttpResponseMessage();

                response = client.PostAsJsonAsync(_url, requestObj).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  
                    string result = response.Content.ReadAsStringAsync().Result;
                    responseObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                }
            }

            return responseObj;
        }


        //api/dokumentumok
        public Dictionary<string, string> GetAllDocument()
        {
            string url = ConfigurationManager.AppSettings["RestApiUrl"];
            Dictionary<string, string> responseObj = new Dictionary<string, string>();
            using (var client = new HttpClient())
            {                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = new HttpResponseMessage();
                 
                response = client.GetAsync(_url).Result;
                
                if (response.IsSuccessStatusCode)
                {
                   
                    string result = response.Content.ReadAsStringAsync().Result;
                    responseObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                }
            }
            return responseObj;
        }
    }
}
