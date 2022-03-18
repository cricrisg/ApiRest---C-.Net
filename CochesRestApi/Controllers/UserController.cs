using Cars.Application.BusinessModels.Request;
using Cars.Application.BusinessModels.Response;
using Cars.Application.Contracts.Mappers;
using Cars.Application.Contracts.Services;
using Cars.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CochesRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;

        }

        //Add
        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult> AddUser(CreateUserRequest createUserRequest)
        {
            
            try
            {
                var result= await _userServices.AddUser(createUserRequest.ToUserModelMapper());

                return Ok(result.ToUserResponseMapper());
            }
            catch (Exception ex)
            {
                
                return BadRequest(new CreateUserResponse(ex.Message,false));
            }

        }


        //Update
        [HttpPut]
        [Route("UpdateUser")]
        public  ActionResult UpdateUser(CreateUserRequest createUserRequest)
        {
            try
            {
                //Metodo del servicio de update cambiando el request a model mediante el mapper
                 _userServices.UpdateUser(createUserRequest.ToUserModelMapper());
                return Ok(new BaseResponse("Insertado", true));

            }catch(Exception ex)
            {
                return BadRequest(new BaseResponse(ex.Message, false));
            }

        }


        //GetAll
        //[HttpPost]
        //[Route("GetUsers")]
        //public async Task<ActionResult> GetAllUser()
        //{

        //    try
        //    {
                
        //        return Ok(await _userServices.GetAll());

               
        //    }
        //    catch (Exception ex)
        //    {

        //        return BadRequest(new CreateUserResponse(ex.Message, false));
        //    }

        //}

        //Delete
        [HttpDelete]
        [Route("DeleteUser")]
        public ActionResult DeleteUser(int id)
        {

            try
            {
               _userServices.DeleteUser(id);

                return Ok(new BaseResponse("Borrado", true));
            }
            catch (Exception ex)
            {

                return BadRequest(new CreateUserResponse(ex.Message, false));
            }

        }

        //GEt one
        [HttpGet]
        [Route("GetUser")]
        public ActionResult GetUser(int id)
        {
            try
            {
                var result = _userServices.GetUser(id);
                return Ok(result.ToUserResponseMapper());

            }catch (Exception ex)
            {
                return BadRequest(new BaseResponse(ex.Message, true));
            }
            
        }





    }
}
