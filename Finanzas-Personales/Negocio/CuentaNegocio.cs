using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CuentaNegocio
    {

        public List<Cuenta> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Cuenta> lista = new List<Cuenta>();

            try
            {
                datos.setearConsulta("select Id,Nombre,Saldo,TipoCuenta from Cuentas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cuenta aux = new Cuenta();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Saldo = (decimal)datos.Lector["Saldo"];
                    aux.TipoCuenta = new TipoDeCuenta();
                    aux.TipoCuenta.Id = (int)datos.Lector["TipoCuenta"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
