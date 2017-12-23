using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class GiphyProviderAdapter : IProviderAdapter
    {
        public const string Host = "https://api.giphy.com";

        public async Task<IEnumerable<ResultItemModel>> GetItems(int page)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync("https://api.giphy.com/v1/gifs/search?api_key=lshMrLcdw0fdohJpl0cUFmPMVdV5iokw&q=doge&limit=10&offset=0&rating=G&lang=en");
                var result = await response.Content.ReadAsStringAsync();
                var giphyResult = JsonConvert.DeserializeObject<GiphyResponseModel>(result);
                return giphyResult.Data.Select(gr => new ResultItemModel()
                {
                    Preview = gr.Images.Preview.Mp4,
                    Original = gr.Images.OriginalMp4.Mp4
                });
            }
        }
    }
}
