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
    public partial class frmMDI : Form
    {

        int contador;
        public frmMDI(int rol)
        {
            contador = rol;
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

            if (contador == 1)
            {
                administradorToolStripMenuItem.Visible = true;
                usuarioToolStripMenuItem.Visible = false;
            }
            else
            {
                administradorToolStripMenuItem.Visible = false;
                usuarioToolStripMenuItem.Visible = true;
            }

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
