using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> listar()
        {
			AccesoDatos datos= new AccesoDatos();
			List<Categoria> lista=new List<Categoria>();

			try
			{
				datos.setearConsulta("select Id,Nombre,TipoMovimiento from Categoria");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Categoria categoria = new Categoria();

					categoria.Id = (int)datos.Lector["Id"];
					categoria.Nombre = (string)datos.Lector["Nombre"];
					categoria.TipoMovimiento = (string)datos.Lector["TipoMovimiento"];

					lista.Add(categoria);
 				}

				return lista;
			}
			catch (Exception ex)
			{

				throw;
			}
        }

    }
}
