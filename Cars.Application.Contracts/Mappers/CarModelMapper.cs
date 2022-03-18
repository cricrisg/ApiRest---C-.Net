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
    public static class CarModelMapper
    {
        public static CarDto ToCarDtoMapper(this CarModel carModel)
        {
            return new CarDto()
            {
                Brand= carModel.Brand,  
                Id=carModel.Id,
                Model=carModel.Model,
                Version=carModel.Version
            };
        }


        public static CarModel ToCarModelMapper(this CarDto carDto)
        {
            return new CarModel()
            {
                Brand = carDto.Brand,
                Id = carDto.Id,
                Model = carDto.Model,
                Version = carDto.Version
            };
        }

        public static CarModel ToCarModelMapper(this Car car)
        {
            return new CarModel()
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                Version= car.Version
            };
        }


        public static CarResponse ToCarResponseMapper(this CarModel carrModel)
        {
            return new CarResponse()
            {
                Id= carrModel.Id,
                Brand= carrModel.Brand,
                Model= carrModel.Model,
                Version= carrModel.Version,
                Status = true
            };
        }

        public static CarModel ToCarModelMapper(this CreateCarRequest createCarRequest)
        {
            return new CarModel()
            {
                Brand = createCarRequest.Brand,
                Model = createCarRequest.Model,
                Version = createCarRequest.Version
            };
        }


        public static CarModel ToCarModelMapper(this UpdateCarRequest updateCarRequest)
        {
            return new CarModel()
            {
                Id= updateCarRequest.Id,
                Brand= updateCarRequest.Brand,
                Model= updateCarRequest.Model,
                Version= updateCarRequest.Version
           
            };
        }

       

        public static Car ToCarMapper(this CarModel car)
        {
            return new Car()
            {
                Id= car.Id,
                Brand=car.Brand,
                Model=car.Model,
                Version=car.Version
            };
        }

        public static List<CarModel> ToListCarModel(this List<Car> car )
        {
            List<CarModel> carModelList = new List<CarModel>();
            foreach (var item in car)
            {
                carModelList.Add(item.ToCarModelMapper());
                
            }

            return carModelList;
        }

        
    }
}
