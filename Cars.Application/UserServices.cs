using Cars.Application.BusinessModels.Models;
using Cars.Application.Contracts.Mappers;
using Cars.Application.Contracts.Services;
using Cars.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Services
{
    public class UserServices : IUserServices
    {
        //Necesitamos el repositorio para conectar con la base de datos
        private readonly IUserRepository _userRepository;
        //Instaciamos el user repository en el constructor. ASí conectamos application y dataAccess
        public UserServices(IUserRepository userRepository)
        {
            _userRepository =userRepository;
        }

        //ADD
        public async Task<UserModel> AddUser(UserModel userModel)
        {
            //Metodo de AddUser creado en repository
            var result = await _userRepository.AddUser(userModel.ToUserDto());
            
            return result.ToUserModel();

        }


        //UPDATE
        public bool UpdateUser(UserModel userModel)
        {
            //Transformamos a User porque repository pide un User
            //Update viene dado de GenericRepository.
            _userRepository.Update(userModel.ToUserMapper());
            //Metodo de generic repository para que guarde los cambios
            _userRepository.SaveChanges();
            
            return true;
        }



        //DELETE
        public bool DeleteUser(int id)
        {
            _userRepository.Delete(id);
            _userRepository.SaveChanges();
            return true;

        }

     

        //GET one USER
        public UserModel GetUser(int id)
        {
            var user=_userRepository.GetByID(id);
            _userRepository.SaveChanges();
            return user.ToUserModelMapper();
        }

        //GETALL
        //public async Task<List<CarModel>> GetAll()
        //{
        //    var list = await _userRepository.GetAsync();

        //    return 
        //}
    }
}

