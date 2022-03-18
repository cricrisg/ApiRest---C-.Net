using Cars.Application.BusinessModels.Models;
using Cars.Application.BusinessModels.Request;
using Cars.Application.BusinessModels.Response;
using Cars.Application.Contracts.Mappers;
using Cars.Application.Contracts.Services;
using Cars.DataAccess.Contracts.Repositories;

namespace Cars.Application.Services
{
    public class CarServices : ICarServices
    {
        private readonly ICarRepository _carRepository;
        public CarServices (ICarRepository carRepository)
        {
            _carRepository=carRepository;   
        }

        //AddCar
        public async Task<CarModel> AddCar(CarModel carModel)
        {
            var result = await _carRepository.AddCar(carModel.ToCarDtoMapper());

            return result.ToCarModelMapper();

        }

        //Get one Car
        public CarModel GetCar(int id)
        {
            var car= _carRepository.GetByID(id);
            _carRepository.SaveChanges();
            return car.ToCarModelMapper();
        }

        //Update
        public bool UpdateCar(CarModel carModel)
        {
             _carRepository.Update(carModel.ToCarMapper());
             _carRepository.SaveChanges();
            return true;
        }

        //Delete
        public bool DeleteCar(int id)
        {
            _carRepository.Delete(id);
            _carRepository.SaveChanges();
            return true;
        }

        //GetAll
        public async Task<List<CarModel>> GetAll()
        {
            var list = await _carRepository.GetAsync();
            
            return list.ToList().ToListCarModel();
        }
    }
}
