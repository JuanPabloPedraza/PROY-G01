﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cuenta
    {

        public int Id { get; set; }
        public int NroCuenta { get; set; }
        public int CVU { get; set; }
        public string Alias { get; set; }
        public int TitularId { get; set; }
        public decimal SaldoCC { get; set; }
        public decimal SaldoCH { get; set; }
        public int LimiteDescubierto { get; set; }
    }
}
