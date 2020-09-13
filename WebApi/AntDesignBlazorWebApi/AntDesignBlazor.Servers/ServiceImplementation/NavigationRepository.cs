using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesignBlazor.Servers.ServiceInterfaces;
using AntDesignModels;
using Microsoft.EntityFrameworkCore;

namespace AntDesignBlazor.Servers.ServiceImplementation
{
    public class NavigationRepository : INavigationRepository
    {
        private readonly AntDesignContext _context;

        public NavigationRepository(AntDesignContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<NavigationInfo>> FindAll()
        {
            return await _context.NavigationInfos.ToListAsync();
        }

        public async Task<NavigationInfo> FindById(int id)
        {
            return await _context.NavigationInfos.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<NavigationInfo> Update(NavigationInfo navigationInfo)
        {
            var result = await FindById(navigationInfo.Id);
            if (result == null) return null;
            result.Path = navigationInfo.Path;
            result.Text = navigationInfo.Text;
            result.NavigationType = navigationInfo.NavigationType;
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<NavigationInfo> Create(NavigationInfo navigationInfo)
        {
            var entity = await _context.NavigationInfos.AddAsync(navigationInfo);
            await _context.SaveChangesAsync();
            return entity.Entity;
        }

        public async Task<NavigationInfo> DeleteById(int id)
        {
            var result = await FindById(id);
            if (result == null) return null;
            _context.NavigationInfos.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }
    }
}