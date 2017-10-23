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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Alumno AlumnoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha_nacimiento.Text.Trim();
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || fecha.Length < 5)
            {
                MessageBox.Show("Es necesario tener todos los campos del formulario lleno ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                Alumno Alumno = new Alumno();

                Alumno._nombre = txtNombre.Text;
                Alumno._apellido = txtApellido.Text;
                Alumno._direccion = txtDireccion.Text;
                Alumno._fecha_nacimiento = txtFecha_nacimiento.Text;


                int resultado = AlumnoDal.Agregar(Alumno);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardado Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un Problema ", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar buscar = new FrmBuscar();
            buscar.ShowDialog();


            if (buscar.alumno_seleccionado!=null)
            {
                AlumnoActual = buscar.alumno_seleccionado;
                txtNombre.Text = buscar.alumno_seleccionado._nombre;
                txtApellido.Text = buscar.alumno_seleccionado._apellido;
                txtDireccion.Text = buscar.alumno_seleccionado._direccion;
                txtFecha_nacimiento.Text = buscar.alumno_seleccionado._fecha_nacimiento;

                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Alumno n_alumno = new Alumno();

            n_alumno._nombre = txtNombre.Text;
            n_alumno._apellido = txtApellido.Text;
            n_alumno._direccion = txtDireccion.Text;
            n_alumno._fecha_nacimiento = txtFecha_nacimiento.Text;
            n_alumno._id = AlumnoActual._id;

            int resultado = AlumnoDal.Modifica(n_alumno);

            if (resultado > 0)
            {
                MessageBox.Show("Alumno modificado con exito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btnGuardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ocurrio un erro al modificar el alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        void limpiar() 
        {

            txtNombre.Clear();
            txtApellido.Clear();
            txtFecha_nacimiento.Clear();
            txtDireccion.Clear();
            txtNombre.Focus();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el alumno.?","Aprobacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int resultado;

                resultado = AlumnoDal.Eliminar(AlumnoActual._id);

                if (resultado > 0)
                {
                    
                 MessageBox.Show("Alumno elimado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ocurrio un erro al querer eliminar el alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("No se pudo eliminar", "ocurrio un error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmRegistro_Usuario usuario = new frmRegistro_Usuario();
            usuario.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

       
    }
}
