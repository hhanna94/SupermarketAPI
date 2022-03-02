using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services.Communication;

namespace SupermarketAPI.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
    }
}