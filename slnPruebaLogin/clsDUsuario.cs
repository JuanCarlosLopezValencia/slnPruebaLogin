using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnPruebaLogin
{
    public class clsDUsuario
    {
        public DataSet consultaDatosUsuario(string NombreUsuario, string Clave)
        {
            DataSet dsUsuario = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsDConexion.conexion.Open();

                string sqlCOnsulta = "select * from tblUsuario " +
                    " where nombreusuario ='" + NombreUsuario +
                    "' and clave='" + Clave + "'";
                adaptador = new SqlDataAdapter(sqlCOnsulta, clsDConexion.conexion);
                adaptador.Fill(dsUsuario, "tblUsuario");

                return dsUsuario;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                clsDConexion.conexion.Close();
            }
        }

    }
}
