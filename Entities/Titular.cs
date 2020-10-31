using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Titular
    {
        public char Adicional { get; set; }
        public int Id { get; set; }
        public char Apellido { get; set; }
        public char Nombre { get; set; }
        public int CUIL { get; set; }
        public int DNI { get; set; }
        public int Contacto { get; set; }

        public int ContactoAlternativo { get; set; }
        public char Correo { get; set; }
    }
}
