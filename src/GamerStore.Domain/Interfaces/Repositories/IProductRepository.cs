using GamerStore.Domain.Entities;

namespace GamerStore.Domain.Interfaces.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId); 
}
