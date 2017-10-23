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
    public partial class frmAutentificacion : Form
    {
        public frmAutentificacion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (UsuarioDal.Autentificar(txtNombre.Text,txtContrasena.Text)>0)
            {
               this.Hide();//para ocultar el fomulario autentificacion
                Form1 registro_alumno = new Form1();

                registro_alumno.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Lo sentimo no tienes acceso al programa");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {

                btnIngresar_Click(sender, e);

            }
            
        }

       
       
    }
}
