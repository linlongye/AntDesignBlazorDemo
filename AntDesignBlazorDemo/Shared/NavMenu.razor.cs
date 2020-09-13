using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AntDesignBlazorDemo.Services;
using AntDesignModels;
using Microsoft.AspNetCore.Components;

namespace AntDesignBlazorDemo.Shared
{
    public partial class NavMenu
    {
        [Inject]
        private  INavigationService NavigationService { get; set; }

        private IEnumerable<NavigationInfo> Menus { get; set; } = new List<NavigationInfo>();

        protected override async Task OnInitializedAsync()
        {
            Menus = await NavigationService.FindAll();
        }
    }
}