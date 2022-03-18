using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModels.Response
{
    public class CreateUserResponse:BaseResponse
    {

        public CreateUserResponse()
        {

        }

        public CreateUserResponse(string messege, bool status):base(messege,status)
        {


        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
