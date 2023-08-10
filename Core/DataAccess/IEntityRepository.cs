using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;

public interface IEntityRepository<TEntity> where TEntity 
    : class, IEntity, new()
{
    /// <summary>
    /// Retrieves all the records from the database.
    /// </summary>
    /// <param name="filter">An optional condition.</param>
    /// <returns>List of entity.</returns>
    List<TEntity> GetListFromDatabase(Expression<Func<TEntity, bool>> filter = null);
    
    /// <summary>
    /// Retrieve the specified record from the database.
    /// </summary>
    /// <param name="filter">Represents the condition.</param>
    /// <returns>A entity based on the condition.</returns>
    TEntity GetFromDatabase(Expression<Func<TEntity, bool>> filter);
    
    /// <summary>
    /// Add a record to the database.
    /// </summary>
    /// <param name="entity">Represents an entity.</param>
    void AddToDatabase(TEntity entity);
    
    /// <summary>
    /// Update a record in the database.
    /// </summary>
    /// <param name="entity">Represents an entity.</param>
    void UpdateInDatabase(TEntity entity);
    
    /// <summary>
    /// Delete a record from the database.
    /// </summary>
    /// <param name="entity">Represents an entity.</param>
    void DeleteFromDatabase(TEntity entity);
}