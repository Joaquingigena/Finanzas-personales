using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MovimientoNegocio
    {
        public void agregar(Movimiento nuevo)
        {
			AccesoDatos datos= new AccesoDatos();
			try
			{
				datos.setearConsulta("insert into Movimiento values(@Tipo,@Fecha,@Descripcion,@Categoria,@Monto,1)");
				datos.setearParametro("@Tipo",nuevo.Tipo);


			}
			catch (Exception ex)
			{

				throw;
			}
			finally { datos.cerrarConexion(); }
        }

    }
}
