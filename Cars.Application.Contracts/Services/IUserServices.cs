using Cars.Application.BusinessModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Contracts.Services
{
    public interface IUserServices
    {
        public Task<UserModel> AddUser(UserModel userModel);
        public bool DeleteUser(int id);

        public Task<List<UserModel>> GetAll();
        public bool UpdateUser(UserModel userModel);

        public UserModel GetUser(int id);
    }
}
