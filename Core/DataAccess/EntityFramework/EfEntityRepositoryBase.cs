using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Core.DataAccess.EntityFramework;

public abstract class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> 
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public List<TEntity> GetListFromDatabase(Expression<Func<TEntity, bool>> filter = null)
    {
        using var context = new TContext();
        return filter == null
            ? context.Set<TEntity>().ToList()
            : context.Set<TEntity>().Where(filter).ToList();
    }

    public TEntity GetFromDatabase(Expression<Func<TEntity, bool>> filter)
    {
        using var context = new TContext();
        return context.Set<TEntity>().SingleOrDefault(filter);
    }

    public void AddToDatabase(TEntity entity)
    {
        using var context = new TContext();
        EntityEntry<TEntity> addedRecord = context.Entry(entity);
        addedRecord.State = EntityState.Added;
        context.SaveChanges();
    }

    public void UpdateInDatabase(TEntity entity)
    {
        using var context = new TContext();
        EntityEntry<TEntity> updatedRecord = context.Entry(entity);
        updatedRecord.State = EntityState.Modified;
        context.SaveChanges();
    }

    public void DeleteFromDatabase(TEntity entity)
    {
        using var context = new TContext();
        EntityEntry<TEntity> deletedRecord = context.Entry(entity);
        deletedRecord.State = EntityState.Detached;
        context.SaveChanges();
    }
}