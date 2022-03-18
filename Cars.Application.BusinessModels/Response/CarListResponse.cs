using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModels.Response
{
    public class CarListResponse
    {
        public List<CarResponse> carResponse { get; set; }

        public CarListResponse()
        {
            this.carResponse = new List<CarResponse>();
        }
    }
}
