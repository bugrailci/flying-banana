using System.Threading.Tasks;
using BYNOGAME.API.Domain.Repositories;
using BYNOGAME.API.Persistence.Contexts;

namespace BYNOGAME.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

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