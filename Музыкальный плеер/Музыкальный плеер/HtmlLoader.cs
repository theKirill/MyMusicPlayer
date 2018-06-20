using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Музыкальный_плеер
{
    class HtmlLoader//класс для загрузки исходного кода страницы
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParser p)
        {
            client = new HttpClient();
            url = $"{p.BaseURL}/";
        }

        public async Task<string> GetSourceByPage()
        {
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}