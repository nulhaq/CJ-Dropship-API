using CJ_Dropship_API.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJ_Dropship_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var cjShoppingClient = new RestClient(ConfigurationManager.AppSettings.Get("CjAccessUrl"));
            var cjShoppingSecret = ConfigurationManager.AppSettings.Get("CjAccessToken");
            var request = new RestRequest("api/product/connectList", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("CJ-Access-Token", cjShoppingSecret);

            var requestBody = new CjRequestBody
            {
                sku = "CJYDQTJM01607-USB"
            };

            request.AddJsonBody(JsonConvert.SerializeObject(requestBody));
            var response = cjShoppingClient.Execute<CjResponse>(request);
            if (response.Data != null)
            {
                //Do something
            }

        }
    }
}
