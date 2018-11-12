using System.Linq;

namespace BarebonesAutoMapperIntegration.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> AsQueryable();

        void Add(T entity);
    }
}