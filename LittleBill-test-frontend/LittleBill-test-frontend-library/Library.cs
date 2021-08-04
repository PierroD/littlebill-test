using LittleBill_test_frontend_library.Helpers;
using LittleBill_test_frontend_library.Models;
using LittleBill_test_frontend_library.Responses;
using LittleBill_test_frontend_library.Responses.WeatherResponse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace LittleBill_test_frontend_library
{
    public class Library
    {
        private static string token;

        public static async Task<bool> Login(string name, string password)
        {
            var content = new LoginModel { name = name, password = password };

            var response = await RequestHelper.PostRequest<LoginResponse>("users/authenticate", content);

            token = response.token;
            return true;
        }

        public static async Task<bool> Register(string name, string email, string password)
        {
            var content = new RegisterModel { name = name, email= email,password = password };

            var response = await RequestHelper.PostRequest<LoginResponse>("users/signup", content);

            token = response.token;
            return true;
        }


        public static async Task<object> Search(string cityname)
        {
            var content = new SearchModel { cityName = cityname, units = "metric", lang = "fr" };
            return await RequestHelper.PostRequest<WeatherResponse>("weather", content, token);
        }

        public static async Task<string> HelloWorld()
        {
            return await RequestHelper.GetRequest<string>("helloworld");
        } 
    }

}

