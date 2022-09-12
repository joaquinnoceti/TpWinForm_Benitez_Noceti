using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.query("Select Id,Descripcion from CATEGORIAS");
                datos.exec();

                while (datos.Dr.Read())
                {
                    Categoria aux = new Categoria();
                    aux.id = (int)datos.Dr["Id"];
                    aux.descr = (string)datos.Dr["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarCN();
            }    
        }
    }
}
