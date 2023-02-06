using System;
using System.Net.Http.Headers;
using Championship_Internal_Front.Models;
using Microsoft.AspNetCore.Mvc;

namespace Championship_Internal_Front.Controllers
{
	public class BaseRequest
	{
        public static HttpClient CreateBaseRequest(HttpClient httpClient)
        {
            try
            {
                String baseUrl = Environment.GetEnvironmentVariable("BASEURL");
                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders.Accept.Add(new
                    MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "Your Oauth token");
                return httpClient;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }

}

