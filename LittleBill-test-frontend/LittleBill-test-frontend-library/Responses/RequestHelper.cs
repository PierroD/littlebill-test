using LittleBill_test_frontend_library.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LittleBill_test_frontend_library.Responses
{
    public class RequestHelper
    {
        public static async Task<T> GetRequest<T>(string uri, string token ="")
        {
            using (HttpResponseMessage response = await LittleBillApiHelper.init(token).GetAsync($"{uri}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<T>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

        public static async Task<T> PostRequest<T>(string uri, object content, string token = "")
        {
            using (HttpResponseMessage response = await LittleBillApiHelper.init(token).PostAsJsonAsync($"{uri}", content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
