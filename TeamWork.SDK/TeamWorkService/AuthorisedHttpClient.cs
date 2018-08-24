using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using TeamWork.SDK.Helper;

namespace TeamWork.SDK.TeamWorkService
{
    class AuthorisedHttpClient : HttpClient
    {
       public AuthorisedHttpClient(Client client)
        {
            BaseAddress = new Uri(client.BaseUrl);
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
              Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(string.Format("{0}:{1}", client.APiKey, "x"))));
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
  
        public async Task<BaseResponse<T>> GetAsync<T>(string endpoint, Dictionary<string, string> paramsDictionary, RequestFormat format = RequestFormat.Json)
        {
            var data = await GetAsync(endpoint);
            if (!data.IsSuccessStatusCode) return new BaseResponse<T>(HttpStatusCode.InternalServerError);
            using (Stream responseStream = await data.Content.ReadAsStreamAsync())
            {
                string jsonMessage = new StreamReader(responseStream).ReadToEnd();
                return new BaseResponse<T>(HttpStatusCode.OK) { ContentObj = JsonConvert.DeserializeObject(jsonMessage, typeof(T)) };
            }
        }

    }
}
