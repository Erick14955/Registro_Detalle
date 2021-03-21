using Registro_Detalle.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Detalle.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Iniciarsesionbutton_Click(object sender, EventArgs e)
        {
            if(EmailtextBox.Text == "user" && PasswordtextBox.Text == "1234")
            {
                MainForm mnf = new MainForm();
                mnf.Show();
            }
            else
            {
                if (UsuariosBLL.ExisteUsuario(EmailtextBox.Text, PasswordtextBox.Text))
                {
                    MainForm mnf = new MainForm();
                    mnf.Show();
                }
                else
                {
                    ErroreserrorProvider.SetError(EmailtextBox, "El email o clave es incorrecto");
                    ErroreserrorProvider.SetError(PasswordtextBox, "El email o clave es incorrecto");
                    PasswordtextBox.Clear();
                }
            }

            EmailtextBox.Clear();
            PasswordtextBox.Clear();
        }

        private void Registrarsebutton_Click(object sender, EventArgs e)
        {
            rUsuario user = new rUsuario();
            user.Show();
        }
    }
}
