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
				datos.setearParametro("@Tipo",nuevo.Tipo.Id);
				datos.setearParametro("@Fecha",nuevo.Fecha);
                datos.setearParametro("@Descripcion",nuevo.Descripcion);
                datos.setearParametro("@Categoria",nuevo.Categoria.Id);
                datos.setearParametro("@Monto",nuevo.Monto);

                datos.ejecutarAccion();



            }
			catch (Exception ex)
			{

				throw;
			}
			finally { datos.cerrarConexion(); }
        }

        public decimal saldoTotal()
        {
			AccesoDatos datos = new AccesoDatos();
			decimal saldo;
			try
			{
				datos.setearProcedimiento("SP_SaldoTotal");

				saldo = datos.ejecutarAccionScalar();

				return saldo;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public decimal totalIngresos()
		{
			AccesoDatos datos= new AccesoDatos();
			decimal ingresos;

			try
			{
				datos.setearConsulta("select isnull(SUM(Monto),0)  from Movimiento where Tipo=1");

				ingresos = datos.ejecutarAccionScalar();

				return ingresos;

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

        public decimal totalGastos()
        {
            AccesoDatos datos = new AccesoDatos();
            decimal gastos;

            try
            {
                datos.setearConsulta("select isnull(SUM(Monto),0)  from Movimiento where Tipo=2");

                gastos = datos.ejecutarAccionScalar();

                return gastos;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
