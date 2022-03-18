using Cars.Application.BusinessModels.Models;
using Cars.Application.BusinessModels.Request;
using Cars.Application.BusinessModels.Response;
using Cars.Application.Contracts.Mappers;
using Cars.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace CochesRestApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarServices _carServices;
        public CarController(ICarServices carServices)
        {
            _carServices = carServices;

        }

        //Add 
        [HttpPost]
        [Route("AddCar")]
        public async Task<ActionResult> AddCar(CreateCarRequest createCarRequest)
        {
            try
            {
                var result = await _carServices.AddCar(createCarRequest.ToCarModelMapper());

                return Ok(result.ToCarResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //Get one Car
        [HttpGet]
        [Route("GetCar")]
        public ActionResult GetCar(int id)
        {
            try
            {
                var result = _carServices.GetCar(id);
                return Ok(result.ToCarResponseMapper());
            } catch (Exception ex)
            {
                return BadRequest(new BaseResponse(ex.Message, false));
            }

        }

        //Update
        [HttpPut]
        [Route("UpdateCar")]
        public ActionResult UpdateCar(UpdateCarRequest updateCarRequest)
        {
            try
            {
                var result = _carServices.UpdateCar(updateCarRequest.ToCarModelMapper());
                return Ok(new BaseResponse("actualizado", true));

            } catch (Exception ex)
            {
                return BadRequest(new BaseResponse(ex.Message, false));
            }
        }

        //Delete
        [HttpDelete]
        [Route("DaleteCar")]
        public ActionResult DeleteCar(int id)
        {
            try
            {
                _carServices.DeleteCar(id);
                return Ok(new BaseResponse("Borrado", true));

            }catch (Exception ex)
            {
                return BadRequest(new BaseResponse(ex.Message, false));
            }
        }

        //GetAll
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            return Ok( await _carServices.GetAll());
           
        }






    }
}
