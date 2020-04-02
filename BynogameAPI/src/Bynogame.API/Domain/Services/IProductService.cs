using System.Threading.Tasks;
using BYNOGAME.API.Domain.Models;
using BYNOGAME.API.Domain.Models.Queries;
using BYNOGAME.API.Domain.Services.Communication;

namespace BYNOGAME.API.Domain.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}