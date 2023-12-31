﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public TipoDeCuenta TipoCuenta { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
