using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ModeraApp.Application.Repository;
using ModeraApp.Domain.Entities;
using ModeraApp.Persistence.Context;

namespace ModeraApp.Persistence.Repository;

public class GenericRepository<T>(AppDbContext dbContext) : IGenericRepository<T> where T : BaseEntity
{
    private readonly DbSet<T> _dbSet = dbContext.Set<T>();

    public async Task<bool> AddAsync(T entity)
    {
        EntityEntry entry = await _dbSet.AddAsync(entity);
        return entry.State == EntityState.Added;
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
        => await _dbSet.AddRangeAsync(entities);

    public bool Update(T entity)
    {
        EntityEntry entry = _dbSet.Update(entity);
        return entry.State == EntityState.Modified;
    }

    public bool Delete(T entity)
    {
        EntityEntry entry = _dbSet.Remove(entity);
        return entry.State == EntityState.Deleted;
    }

    public void UpdateRange(IEnumerable<T> entities)
        => _dbSet.UpdateRange(entities);

    public void DeleteRange(IEnumerable<T> entities)
        => _dbSet.RemoveRange(entities);

    public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
    {
        var query = _dbSet.Where(predicate);
        return query;
    }

    public async Task<bool> IsExistsAsync(Expression<Func<T, bool>> predicate)
        => await _dbSet.AnyAsync(predicate);

    public int Save()
        => dbContext.SaveChanges();

    public async Task<int> SaveAsync()
        => await dbContext.SaveChangesAsync();
}