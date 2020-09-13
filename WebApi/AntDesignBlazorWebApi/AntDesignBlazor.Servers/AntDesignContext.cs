using AntDesignModels;
using Microsoft.EntityFrameworkCore;

namespace AntDesignBlazor.Servers
{
    public class AntDesignContext : DbContext
    {
        public AntDesignContext(DbContextOptions<AntDesignContext> options) : base(options)
        {
        }

        public DbSet<NavigationInfo> NavigationInfos { get; set; }
    }
}