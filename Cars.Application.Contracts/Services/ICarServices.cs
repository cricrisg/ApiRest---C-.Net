using Cars.Application.BusinessModels.Models;
using Cars.Application.BusinessModels.Request;
using Cars.Application.BusinessModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Contracts.Services
{
    public interface ICarServices
    {
        public Task<CarModel> AddCar(CarModel carModel);
        public CarModel GetCar(int id);
        public Task<List<CarModel>> GetAll();
        public bool UpdateCar(CarModel model);
        public bool DeleteCar(int id);
    }
}
