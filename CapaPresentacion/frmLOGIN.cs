using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLOGIN : Form
    {

        clsNUsuario objUsuario = new clsNUsuario();

        DataSet dsUsuario = new DataSet();
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dsUsuario = objUsuario.consultaUsuario(txtUser.Text, txtClave.Text);


            int rol = int.Parse(dsUsuario.Tables["tblUsuario"].Rows[0]["idRol"].ToString());

            frmMdi formaMDI = new frmMdi(rol);

            formaMDI.Show();
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
