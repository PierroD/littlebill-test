using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LittleBill_test_frontend_library.Helpers
{
    public class LittleBillApiHelper
    {
        private static HttpClient apiUrl { get; set; }
        public static HttpClient init(string token = "")
        {
            apiUrl = new HttpClient(new HttpClientHandler());
            apiUrl.BaseAddress = new Uri("http://localhost:4000/");
            apiUrl.DefaultRequestHeaders.Accept.Clear();
            apiUrl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if(StringHelper.isNotNullOrEmpty(token))
            {
               apiUrl.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return apiUrl;
        }
    }
}
