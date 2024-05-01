using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SocialMediaProject
{
    internal class Categories
    {
        private readonly string api_key = ""; // DOLDURULACAK
        private readonly string region_code = "TR";
        private readonly string url;

        internal Categories()
        {
            url = "https://www.googleapis.com/youtube/v3/videoCategories?part=snippet&regionCode=" + region_code + "&key=" + api_key;
        }

        public async Task<string> GetVideoCategories()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception($"API çağrısı başarısız. Hata kodu: {response.StatusCode}");
                }
            }
        }
    }

    public class AllCategories
    {
        public List<Item> items { get; set; }

        public class Item
        {
            public string id { get; set; }
            public Snippet snippet { get; set; }

            public class Snippet
            {
                public string title { get; set; }
                public bool assignable { get; set; }
            }
        }
    }
}
