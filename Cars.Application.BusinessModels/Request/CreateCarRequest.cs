using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModels.Request
{
    public class CreateCarRequest
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }

    }
}
