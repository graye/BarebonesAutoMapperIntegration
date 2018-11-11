using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarebonesAutoMapperIntegration.Repository
{
    public static class MockDelayExtensions
    {
        private const int Delay = 1000;
        
        public static async Task<List<T>> ToListAsync<T>(this IEnumerable<T> enumerable)
        {
            await Task.Delay(Delay);
            return enumerable.ToList();
        }
        
        public static async Task<T[]> ToArrayAsync<T>(this IEnumerable<T> enumerable)
        {
            await Task.Delay(Delay);
            return enumerable.ToArray();
        }
        
        public static async Task<T> FirstAsync<T>(this IEnumerable<T> enumerable)
        {
            await Task.Delay(Delay);
            return enumerable.First();
        }
    }
}