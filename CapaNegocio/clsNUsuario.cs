using slnPruebaLogin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsNUsuario
    {
        clsDUsuario objDatosUsuario = new clsDUsuario();

        public string nombreUsuario { get; set; }

        public string codClave { get; set; }

        public int rol { get; set; }

        public DataSet consultaUsuario(string usuario, string clave)
        {
            nombreUsuario = usuario;
            codClave = clave;

            return objDatosUsuario.consultaDatosUsuario(nombreUsuario, codClave);
        }
    }


}
