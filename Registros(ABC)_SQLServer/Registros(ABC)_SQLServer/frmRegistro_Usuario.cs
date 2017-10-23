using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros_ABC__SQLServer
{
    public partial class frmRegistro_Usuario : Form
    {
        public frmRegistro_Usuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtConfir_Contrasena.Text) 
            {
                if (UsuarioDal.Crear_Cuenta(txtNombre.Text,txtContrasena.Text)>0)
                {
                    MessageBox.Show("Cuenta de usuario creada con exito");
                    
                    txtNombre.Text = "";
                    txtContrasena.Text = "";
                    txtConfir_Contrasena.Text = "";
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta de usuario");
                }

            }
            else
            {
                MessageBox.Show("los campos contraseña no es igual a confirmar contraseña ");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
