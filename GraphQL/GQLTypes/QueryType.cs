using GraphQL.Data;
using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.GQLTypes
{
    public class QueryType
    {
        public async Task<IEnumerable<Cake>> GetAllCakesAsync([Service] GQLContext context) => await context.Cakes.ToListAsync();
        public async Task<Cake> GetCakeByIdAsync([Service] GQLContext context, int Id) => await context.Cakes.FindAsync(Id);

    }
}
