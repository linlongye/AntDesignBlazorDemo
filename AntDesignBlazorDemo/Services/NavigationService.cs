using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AntDesignModels;
using Microsoft.AspNetCore.Components;

namespace AntDesignBlazorDemo.Services
{
    public class NavigationService : INavigationService
    {
        private readonly HttpClient _httpClient;

        public NavigationService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("default_client");
        }

        public async Task<IEnumerable<NavigationInfo>> FindAll()
        {
            return await _httpClient.GetJsonAsync<NavigationInfo[]>("navigation/findall");
        }
    }
}