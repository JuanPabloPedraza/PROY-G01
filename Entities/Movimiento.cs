using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Movimiento
    {
        public int Id { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int CuotasTotales { get; set; }
        public int CuotasPagas { get; set; }
        public int CodMovimiento { get; set; }
        public int TipoMovimientoId { get; set; }
        public int TarjetaId { get; set; }
        public int CuentaId { get; set; }
    }
}
