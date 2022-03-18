using Cars.Application.BusinessModels.Models;
using Cars.Application.BusinessModels.Request;
using Cars.Application.BusinessModels.Response;
using Cars.DataAccess.Contracts.Dtos;
using Cars.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Contracts.Mappers
{
    public static class UserModelMapper
    {
        //Mapeo de Request a Model
        public static UserModel ToUserModelMapper(this CreateUserRequest createUserRequest)
        {
            return new UserModel()
            {
                Name = createUserRequest.Name,
                Email = createUserRequest.Email,
                Password = createUserRequest.Password
            };
        }

        //Convertimos el UserModel a userDto
        public static UserDto ToUserDto(this UserModel user)
        {
            return new UserDto()
            {
                Name = user.Name,
                Id = user.Id,
                Email = user.Email,
                Password = user.Password
            };
        }

        //Mapeo de Dto a UserModel
        public static UserModel ToUserModel(this UserDto userDto)
        {
            return new UserModel()
            {
                Name = userDto.Name,
                Id = userDto.Id,
                Email = userDto.Email,
                Password = userDto.Password
            };
        }



        //Mapeo de Model a response
        public static CreateUserResponse ToUserResponseMapper(this UserModel userModel)
        {
            return new CreateUserResponse()
            {
                Name = userModel.Name,
                Email = userModel.Email,
                Password = userModel.Password,
                Id = userModel.Id,
                Status = true
            };
        }

        //Mapeo de Model a User(Entity)
        public static User ToUserMapper(this UserModel user)
        {
            return new User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }

        //Mapeo de USer(Entity) a Model
        public static UserModel ToUserModelMapper(this User user)
        {
            return new UserModel()
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
                Name = user.Name
            };
        }

        //Mapeo de Lista de User a USerModel para que los devuelva todos
        public static List<UserModel> ToListUserModel(this List<User> user)
        {
            List<UserModel> userModelList = new List<UserModel>();
            foreach (var item in user)
            {
                userModelList.Add(item.ToUserModelMapper());

            }

            return userModelList;
        }

    }
}
