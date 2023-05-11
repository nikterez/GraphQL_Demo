using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data
{
    public class GQLContext: DbContext
    {
        public GQLContext(DbContextOptions<GQLContext> options):base(options)
        {
            
        }

        public virtual DbSet<Cake> Cakes { get; set; }
    }
}
