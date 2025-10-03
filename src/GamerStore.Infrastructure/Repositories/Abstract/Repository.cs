using GamerStore.Domain.Interfaces.Repositories;
using GamerStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GamerStore.Infrastructure.Repositories.Abstract;

public abstract class Repository<TEntity>(GamerStoreDbContext context) : IRepository<TEntity> where TEntity : class
{
    protected readonly GamerStoreDbContext _context = context;
    protected readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        TEntity entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

}
