using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<List<Expenditure>> GetAllExpenditureByUserId(int Id);
        Task<List<Income>> GetAllIncomesByUserId(int Id);
    }
}
