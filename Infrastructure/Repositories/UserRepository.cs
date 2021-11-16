using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Expenditure>> GetAllExpenditures(int Id)
        {
            var expenditures = await _dbContext.Expenditures.Where(e => e.UserId == Id).ToListAsync();
            return expenditures;
        }

        public async Task<IEnumerable<Income>> GetAllIncomes(int Id)
        {
            var incomes = await _dbContext.Incomes.Where(i => i.UserId == Id).ToListAsync();
            return incomes;
        }

        public async Task<string> GetFullName(int Id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == Id);
            return user.FullName;
        }
    }
}
