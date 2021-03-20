using BlockingThreads.Models;
using BlockingThreads.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockingThreads.Services.Impl
{
    public class DbService : IDbService
    {
        private const int NumberOfItems = 3000000;

        public IEnumerable<DbItem> GetAll()
        {
            var result = new List<DbItem>();
            var random = new Random();
            for (int i = 0; i < NumberOfItems; ++i)
            {
                result.Add(new DbItem { Name = $"Item sync {i}", Price = random.Next(0, i) });
            }

            return result;
        }

        public async Task<IEnumerable<DbItem>> GetAllAsync()
        {
            return await Task.FromResult(CreateItems());
        }

        private IEnumerable<DbItem> CreateItems()
        {
            var result = new List<DbItem>();
            var random = new Random();
            for (int i = 0; i < NumberOfItems; ++i)
            {
                result.Add(new DbItem { Name = $"Item async{i}", Price = random.Next(0, i) });
            }

            return result;
        }
    }
}
