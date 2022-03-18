using Cars.DataAccess.Contracts.Dtos;
using Cars.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Contracts.Mapper
{
    public static class UserMapper
    {
        //Mapea el user Dto y devuelve un user de la entidad de BBDD
        public static User ToUserMapper(this UserDto userDto)
        {
            return new User
            {
                Id = userDto.Id,
                Name = userDto.Name,
                Email = userDto.Email,
                Password = userDto.Password
            };
        }

        public static UserDto ToUserDtoMapper(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}
