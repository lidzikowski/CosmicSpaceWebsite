using CosmicSpaceWebsiteDll;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CosmicSpaceWebsite
{
    public class Utils
    {
        public static async Task<T> HttpGetAsync<T>(HttpClient Http, ApiTypeService apiTypeService, ApiService service, Dictionary<string, object> parameters = null)
        {
            string api = $"https://localhost:44396/api/{apiTypeService.ToString()}/{service.ToString()}";

            if(parameters != null)
            {
                bool first = true;
                foreach (var item in parameters)
                {
                    api += $"{(first ? "?" : "&")}{item.Key}={item.Value}";
                    first = false;
                }
            }

            var response = await Http.GetAsync(api);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<T>();
        }
    }
}