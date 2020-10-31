using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Titular
    {
        public int Id { get; set; }

        public string Adicional { get; set; }
        
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public int CUIL { get; set; }
        public int DNI { get; set; }
        public int Contacto { get; set; }
        public int ContactoAlternativo { get; set; }
        public string Correo { get; set; }
    }
}
