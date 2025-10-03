namespace GamerStore.Domain.Entities;

public class Cart
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime CreationDate { get; set; }
    public bool Finished { get; set; }
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    public User User { get; set; }
}
