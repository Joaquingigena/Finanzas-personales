using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio
{
    public class Movimiento
    {

        public int Id { get; set; }
        public Cuenta Cuenta { get; set; }
        public Tipo Tipo { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal  Monto { get; set; }
        public bool Activo { get; set; }


    }
}
