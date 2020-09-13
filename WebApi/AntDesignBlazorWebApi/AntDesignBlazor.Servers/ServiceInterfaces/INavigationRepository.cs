using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesignModels;

namespace AntDesignBlazor.Servers.ServiceInterfaces
{
    public interface INavigationRepository
    {
        Task<IEnumerable<NavigationInfo>> FindAll();
        Task<NavigationInfo> FindById(int id);
        Task<NavigationInfo> Update(NavigationInfo navigationInfo);
        Task<NavigationInfo> Create(NavigationInfo navigationInfo);
        Task<NavigationInfo> DeleteById(int id);
    }
}