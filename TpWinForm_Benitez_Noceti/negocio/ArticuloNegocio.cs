using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString = "server=DESKTOP-ED31VDF; database=CATALOGO_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select codigo,nombre,a.descripcion,c.Descripcion Cat,m.Descripcion Mar,imagenurl,Precio from ARTICULOS a join CATEGORIAS c on (a.IdCategoria = c.Id) join MARCAS m on (a.IdMarca = m.id)";
                cmd.Connection = cn;

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codArt = (string)dr["codigo"];
                    aux.Nombre = (string)dr["nombre"];
                    aux.descripcion = (string)dr["descripcion"];
                    aux.marca = new Marca();
                    aux.marca.descr = (string)dr["Mar"];
                    aux.categoria = new Categoria();
                    aux.categoria.descr = (string)dr["Cat"];
                    aux.imagen = (string)dr["imagenurl"];
                    aux.precio = Convert.ToDouble(dr["Precio"]);

                    lista.Add(aux);
                }
                cn.Close(); 

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
