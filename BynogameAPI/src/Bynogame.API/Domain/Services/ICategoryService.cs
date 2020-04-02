using System.Collections.Generic;
using System.Threading.Tasks;
using BYNOGAME.API.Domain.Models;
using BYNOGAME.API.Domain.Services.Communication;

namespace BYNOGAME.API.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
         Task<CategoryResponse> SaveAsync(Category category);
         Task<CategoryResponse> UpdateAsync(int id, Category category);
         Task<CategoryResponse> DeleteAsync(int id);
    }
}