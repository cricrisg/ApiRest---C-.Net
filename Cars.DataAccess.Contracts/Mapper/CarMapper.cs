using Cars.DataAccess.Contracts.Dtos;
using Cars.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Contracts.Mapper
{
    public static class CarMapper
    {
        public static Car ToCarMapper(this CarDto carDto)
        {
            return new Car
            {
                Id = carDto.Id,
                Brand = carDto.Brand,
                Model = carDto.Model,
                Version = carDto.Version
            };
        }

        public static CarDto ToCarDtoMapper(this Car car)
        {
            return new CarDto
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                Version = car.Version
            };
        }


    }
}
