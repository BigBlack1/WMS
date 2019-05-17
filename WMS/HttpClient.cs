using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WMS
{
    public static class HttpClientr
    {
        public static string Apiresult(string request, string actonName, object obj = null)
        {
            string json = "";
            Task<HttpResponseMessage> task = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60847/api/yyl/");
            switch (request)
            {
                case "get":
                    task = client.GetAsync(actonName);
                    break;
                case "post":
                    task = client.PostAsJsonAsync(actonName, obj);
                    break;
                case "delete":
                    task = client.DeleteAsync(actonName);
                    break;
                case "put":
                    task = client.PutAsJsonAsync(actonName, obj);
                    break;
                default:
                    break;
            }
            task.Wait();
            var jieguo = task.Result;
            if (jieguo.IsSuccessStatusCode)
            {
                var read = jieguo.Content.ReadAsStringAsync();
                read.Wait();
                json = read.Result;
            }
            return json;
        }
    }
}
