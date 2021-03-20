using BlockingThreads.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockingThreads.Services.Contracts
{
    public interface IDbService
    {
        Task<IEnumerable<DbItem>> GetAllAsync();

        IEnumerable<DbItem> GetAll();
    }
}
