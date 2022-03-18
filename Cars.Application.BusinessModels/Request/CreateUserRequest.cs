using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModels.Request
{
    //Request que se puede reutilizar para más peticiones(Update, etc)
    //Tambien se puede crear un request para cada petición
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
