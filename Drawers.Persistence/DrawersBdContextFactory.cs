using Microsoft.EntityFrameworkCore;
using Drawers.Persistence.Infrastructure;

namespace Drawers.Persistence
{
    public class DrawersDbContextFactory : DesignTimeDbContextFactoryBase<DrawersDbContext>
    {
        protected override DrawersDbContext CreateNewInstance(DbContextOptions<DrawersDbContext> options)
        {
            return new DrawersDbContext(options);
        }
    }
}