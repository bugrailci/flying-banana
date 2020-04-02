using System.Threading.Tasks;

namespace BYNOGAME.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}