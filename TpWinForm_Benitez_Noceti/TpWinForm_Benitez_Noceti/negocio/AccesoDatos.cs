using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public SqlDataReader Dr
        {
            get { return dr; }
        }

        public AccesoDatos()
        {//""Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CATALOGO_DB;Data Source=JUANCRUZW\\SQLEXPRESS"
            cn = new SqlConnection("server=DESKTOP-ED31VDF; database=CATALOGO_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        public void query(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }

        public void exec()
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void execQuery()
        {
            cmd.Connection= cn;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametros(string Nombre, object valor)
        {
            cmd.Parameters.AddWithValue(Nombre, valor);
        }

        public void cerrarCN()
        {
            if (dr != null)
                dr.Close();
            cn.Close();
        }

    }
}

