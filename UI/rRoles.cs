using Registro_Detalle.BLL;
using Registro_Detalle.Entidades;
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
    public partial class rRoles : Form
    {
        public List<RolesDetalle> Detalle { get; set; }
        public rRoles()
        {
            InitializeComponent();
            this.Detalle = new List<RolesDetalle>();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            ErroreserrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            EsActivocheckBox.Checked = false;
            AsignadocheckBox.Checked = false;
            this.Detalle = new List<RolesDetalle>();
            CargarGrid();
        }

        private void LlenarCampos(Roles rol)
        {
            IDnumericUpDown.Value = rol.RolID;
            DescripciontextBox.Text = rol.DescripcionRol;
            EsActivocheckBox.Checked = rol.EsActivo;

            this.Detalle = rol.Detalle;
            CargarGrid();
        }

        private Roles LlenarClase()
        {
            Roles rol = new Roles();
            rol.RolID = (int)IDnumericUpDown.Value;
            rol.DescripcionRol = DescripciontextBox.Text;
            rol.EsActivo = EsActivocheckBox.Checked;
            rol.Detalle = this.Detalle;
            CargarGrid();

            return rol;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Roles rol = new Roles();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            rol = RolesBLL.Buscar(id);

            if(rol != null)
            {
                LlenarCampos(rol);
            }
            else
            {
                MessageBox.Show("El rol no ha sido encontrada o no esta registrada");
            }
        }

        private bool Validar()
        {
            bool paso = true;

            if(DescripciontextBox.Text == string.Empty)
            {
                ErroreserrorProvider.SetError(DescripciontextBox, "Este campo no puede quedar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            if (RolesBLL.ExisteDescripcion(DescripciontextBox.Text))
            {
                ErroreserrorProvider.SetError(DescripciontextBox, "Esta descripcion ya existe en la base de datos");
                DescripciontextBox.Focus();
                paso = false;
            }

            if(PermisoscomboBox.Text == string.Empty)
            {
                ErroreserrorProvider.SetError(PermisoscomboBox, "Debe seleccion un Id");
                PermisoscomboBox.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                ErroreserrorProvider.SetError(DetalledataGridView, "Es necesario agregar un permis");
                DetalledataGridView.Focus();
                paso = false;
            }

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;
            if (!Validar())
            {
                return;
            }

            rol = LlenarClase();
            paso = RolesBLL.Guardar(rol);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Limpiar();
                MessageBox.Show("Transaccion fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();
            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("Rol eliminado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ErroreserrorProvider.SetError(IDnumericUpDown, "ID no existe en la base de datos");
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<RolesDetalle>)DetalledataGridView.DataSource;

            this.Detalle.Add(
                new RolesDetalle(
                    id: 0,
                    rolid: (int)IDnumericUpDown.Value,
                    permisoid: Convert.ToInt32(PermisoscomboBox.Text),
                    asigned: AsignadocheckBox.Checked
                    )
                );
            CargarGrid();
            PermisoscomboBox.Focus();
            PermisoscomboBox.Text = "";
            AsignadocheckBox.Checked = true;
        }

        private void EliminarPermisobutton_Click(object sender, EventArgs e)
        {
            if((DetalledataGridView.Rows.Count > 0) && (DetalledataGridView.CurrentRow != null))
            {
                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
            else
            {
                ErroreserrorProvider.SetError(DetalledataGridView, "No existen filas las cuales eliminar");
                DetalledataGridView.Focus();
            }
        }

        private void rRoles_Load(object sender, EventArgs e)
        {
            PermisoscomboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoscomboBox.DisplayMember = "PermisosId";
            PermisoscomboBox.ValueMember = "DescripcionPermisos";
        }
    }
}
