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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        public Alumno alumno_seleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar_alumno.DataSource = AlumnoDal.Buscar_Alumno(txtnombre.Text, txtapellido.Text);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvBuscar_alumno.SelectedRows.Count==1)
            {
                Int64 id = Convert.ToInt64(dgvBuscar_alumno.CurrentRow.Cells[0].Value);
                alumno_seleccionado = AlumnoDal.Obtener_Alumno(id);
                this.Close();

            }
            else
            {
                MessageBox.Show("Aun no selecciona ningun alumno ");   
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
