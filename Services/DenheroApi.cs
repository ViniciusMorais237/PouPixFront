using System.Net.Http.Json;
using PouPixFront.Components.Classes;
using SiteBlazor.Response;

namespace SiteBlazor.Services
{
    public class DenheroApi
    {
        private readonly HttpClient _httpClient;

        public DenheroApi(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }

        public async Task<IndicadoresPaginaInicialResponse?> GetIndicadores()
        {
            return await _httpClient.GetFromJsonAsync<IndicadoresPaginaInicialResponse>($"PaginaInicial");
        }

        public async Task<List<HistoricoCompraResponse>?> GetHistoricoCompras(string date)
        {
            return await _httpClient.GetFromJsonAsync<List<HistoricoCompraResponse>>($"Compras/{date}");
        }

        public async Task<bool> AdicionarCompra(NovaCompra novaCompra)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsJsonAsync("Compras", novaCompra);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException)
            {

                throw;
            }
        }

    }
}