using GamerStore.Domain.Entities;
using GamerStore.Domain.Interfaces.Repositories;
using GamerStore.Infrastructure.Data;
using GamerStore.Infrastructure.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GamerStore.Infrastructure.Repositories;

public class ProductRepository(GamerStoreDbContext context) : Repository<Product>(context), IProductRepository
{
    public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId)
    {
        return await _dbSet.Where(product => product.CategoryId == categoryId).Include(product => product.Category).ToListAsync();
    }
}
