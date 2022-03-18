using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Contracts.Dtos
{
    public class CarDto
    {
        public int Id { get; set; }
        
        public string Brand { get; set; }
        
        public string Model { get; set; }

        public string Version { get; set; }
    }
}
