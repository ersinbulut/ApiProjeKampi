using ApiProjeKampi.WebUI.Dtos.CategoryDtos;
using ApiProjeKampi.WebUI.Dtos.ProductDtos;
using ApiProjeKampi.WebUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiProjeKampi.WebUI.ViewComponents.DefaultMenuViewComponents
{
    public class _DefaultMenuProductComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultMenuProductComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7096/api/Products");

            if (responseMessage != null && responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }

            // Eğer null ise veya başarısızsa boş modelle döner
            return View(new List<ResultServiceDto>());
        }
    }
}
