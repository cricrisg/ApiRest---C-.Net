using Cars.DataAccess.Contracts.Dtos;
using Cars.DataAccess.Contracts.Entities;
using Cars.DataAccess.Contracts.Mapper;
using Cars.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Services.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {

        #region parte de la arquitectura

        private readonly ApplicationDbContext _dbContext;

        public CarRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #endregion


        //AddCar
        public async Task<CarDto> AddCar(CarDto carDto)
        {
            var resultEntity = await _dbContext.Cars.AddAsync(carDto.ToCarMapper());
            _dbContext.SaveChanges();
            return resultEntity.Entity.ToCarDtoMapper();
        }

        

    }
}
