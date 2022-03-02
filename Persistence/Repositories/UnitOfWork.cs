using System.Threading.Tasks;
using SupermarketAPI.Domain.Repositories;
using SupermarketAPI.Persistence.Contexts;

namespace SupermarketAPI.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}