using GraphQL.Data;
using GraphQL.Models;

namespace GraphQL.GQLTypes
{
    public class MutationType
    {

        public async Task<Cake> CreateCakeAsync([Service] GQLContext _context,Cake newCake)
        {
            await _context.Cakes.AddAsync(newCake);
            await _context.SaveChangesAsync();
            return newCake;
        }

        public async Task<Cake> UpdateCakeAsync([Service] GQLContext _context, Cake cakeToUpdate)
        {
            _context.Cakes.Update(cakeToUpdate);
            await _context.SaveChangesAsync();
            return cakeToUpdate;
        }

        public async Task<string> DeleteCakeByEntityAsync([Service] GQLContext _context, Cake cakeToDelete)
        {
            if (cakeToDelete == null)
            {
                return "Invalid operation";
            }
            _context.Cakes.Remove(cakeToDelete);
            await _context.SaveChangesAsync();
            return "Cake deleted";
        }

        public async Task<string> DeleteCakeByIdAsync([Service] GQLContext _context, int id)
        {
            var cakeToDelete = await _context.Cakes.FindAsync(id);
            if (cakeToDelete == null)
            {
                return "Invalid operation";
            }
            _context.Cakes.Remove(cakeToDelete);
            await _context.SaveChangesAsync();
            return "Cake deleted";
        }

    }
}
