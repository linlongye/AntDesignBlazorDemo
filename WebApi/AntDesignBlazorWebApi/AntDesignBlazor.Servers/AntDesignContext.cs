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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NavigationInfo>()
                .HasMany(x => x.Children)
                .WithOne(x => x.Parent)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);
        }
    }
}