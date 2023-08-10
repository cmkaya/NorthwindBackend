using Core.Entities;

namespace Entities.Concrete;

/// <summary>
/// Represents a product entity with a id, product name,
/// stock amount, unit price and quantity per unit.
/// </summary>
public class Product : IEntity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public string QuantityPerUnit { get; set; }
    
    public int CategoryId { get; set; }
}