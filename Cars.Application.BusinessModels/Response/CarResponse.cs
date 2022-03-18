using Cars.Application.BusinessModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModels.Response
{
    public class CarResponse: BaseResponse
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }

    }
}
