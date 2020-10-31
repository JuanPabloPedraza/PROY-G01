using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tarjeta
    {
        public int Id { get; set; }
        public int NroTarjeta { get; set; }
        public int clave { get; set; }
        public int TitularId { get; set; }
        public string TipoTarjeta { get; set; }
        public decimal LimiteCompra { get; set; }
        public int MaxCuotas { get; set; }
        public decimal InteresMensual { get; set; }
    }
}
