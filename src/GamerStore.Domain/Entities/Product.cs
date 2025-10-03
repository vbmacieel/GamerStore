namespace GamerStore.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Value { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public required Category Category { get; set; }
}
