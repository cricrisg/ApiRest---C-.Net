using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModels.Response
{
    public class BaseResponse
    {

        public BaseResponse()
        {
        }

        public BaseResponse(string messege, bool status)
        {
            this.Status = status;
            this.Message = messege;
        }

        public string Message { get; set; }    

        public bool Status { get; set; }    
    }
}
