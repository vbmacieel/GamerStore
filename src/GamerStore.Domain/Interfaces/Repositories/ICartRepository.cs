using GamerStore.Domain.Entities;

namespace GamerStore.Domain.Interfaces.Repositories;

public interface ICartRepository : IRepository<Cart>
{
    Task<Cart> GetActiveCartByUserIdAsync(int userId);
}
