using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services.Communication;

namespace SupermarketAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
    }
}