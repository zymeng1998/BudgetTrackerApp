using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            var users = _userRepository.List();
            return users;
        }

        public async Task<UserDetailResponseModel> GetUserDetail(int Id)
        {
            var expenditures = await _userRepository.GetAllExpenditures(Id);
            var incomes = await _userRepository.GetAllIncomes(Id);
            var fullname = await _userRepository.GetFullName(Id);

            return new UserDetailResponseModel
            {
                Expenditures = expenditures,
                Incomes = incomes,
                FullName = fullname,
                UserId = Id
            };
        }
    }
}
