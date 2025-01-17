using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
         Task<IReadOnlyList<T>> ListAllAsync();
         Task<T> GetByIdAsync(int id);
         Task<T> GetEntityWithSpec(ISpecification<T> spec);
         Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
         Task<int> CountAsync(ISpecification<T> spec);
    }
}