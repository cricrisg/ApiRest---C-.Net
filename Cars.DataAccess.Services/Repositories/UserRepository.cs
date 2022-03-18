using Cars.DataAccess.Contracts.Dtos;
using Cars.DataAccess.Contracts.Entities;
using Cars.DataAccess.Contracts.Repositories;
using Cars.DataAccess.Contracts.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Services.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        //AddUser metodo no creado en el generic
        public async Task<UserDto> AddUser(UserDto userDto)
        {
            var userEntity = await _dbContext.Users.AddAsync(userDto.ToUserMapper());
            _dbContext.SaveChanges();

            return userEntity.Entity.ToUserDtoMapper();
        }

       
       
    }
}
