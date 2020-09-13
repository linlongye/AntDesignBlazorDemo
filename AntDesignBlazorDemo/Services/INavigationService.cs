using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesignModels;

namespace AntDesignBlazorDemo.Services
{
    public interface INavigationService
    {
        Task<IEnumerable<NavigationInfo>> FindAll();
    }
}