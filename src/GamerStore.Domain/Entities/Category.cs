namespace GamerStore.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Produtos { get; set; } = new List<Product>();
}
