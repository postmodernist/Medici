using Microsoft.EntityFrameworkCore;
using ResourceAG.Domain.Entities;

namespace ResourceAG.Infrastructure.DBContext
{
    public class ResourceDBContext: DbContext
    {
        public DbSet<ResourceItem> ResourceItems { get; set; }
    }
}