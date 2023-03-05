using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema2.modelos
{
    public class user
    {
        public string usernames { get; set; }
        public string names { get; set; }
        public string apellidoPater { get; set; } 
        public string apellidoMater { get; set; }
        public string correo { get; set; }
        public string institucion { get; set; }
        public string contraseña { get;set;}
        public string[] scopes { get; set; }
    }
}
