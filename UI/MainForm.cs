using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Detalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.UsuariosToolStripMenuItem.Click += new EventHandler(this.UsuariosToolStripMenuItem_ItemClicked);
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItem_ItemClicked);
            this.PermisosToolStripMenuItem.Click += new EventHandler(this.PermisosToolStripMenuItem_ItemClicked);
        }

        private void UsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rUsuario usuarios = new rUsuario();
            usuarios.MdiParent = this;
            usuarios.Visible = true;
        }

        private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rRoles roles = new rRoles();
            roles.MdiParent = this;
            roles.Visible = true;
        }

        private void PermisosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rPermisos permisos = new rPermisos();
            permisos.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
