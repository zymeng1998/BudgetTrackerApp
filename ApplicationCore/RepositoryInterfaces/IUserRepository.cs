using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<IEnumerable<Expenditure>> GetAllExpenditures(int Id);
        Task<IEnumerable<Income>> GetAllIncomes(int Id);
        Task<string> GetFullName(int Id);
    }
}
