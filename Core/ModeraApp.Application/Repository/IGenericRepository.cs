using System.Linq.Expressions;
using ModeraApp.Domain.Entities;

namespace ModeraApp.Application.Repository;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T entity); 
    Task AddRangeAsync(IEnumerable<T> entities);
    bool Update(T entity);
    bool Delete(T entity);
    void UpdateRange(IEnumerable<T> entities);
    void DeleteRange(IEnumerable<T> entities);
    IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    Task<bool> IsExistsAsync(Expression<Func<T, bool>> predicate);
    int Save();
    Task<int> SaveAsync();

}