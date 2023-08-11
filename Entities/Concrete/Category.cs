using Core.Entities;

namespace Entities.Concrete;

/// <summary>
/// Represents a category entity with a id, category name,
/// and description.
/// </summary>
public class Category : IEntity
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}