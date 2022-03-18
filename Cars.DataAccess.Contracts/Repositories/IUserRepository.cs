using Cars.DataAccess.Contracts.Dtos;
using Cars.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Contracts.Repositories
{
    public interface IUserRepository: IGenericRespository<User>
    {
        public Task<UserDto> AddUser(UserDto userDto);
        
      

    }
}
