using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class ActualizarInfoAlumno : Form
    {

        private Alumno alumno;
        public string NuevoTel { get; private set; }
        public string NuevaDir { get; private set; }

        public ActualizarInfoAlumno(Alumno alumnoSeleccionado)
        {
            InitializeComponent();
            this.alumno = alumnoSeleccionado;

        }

        private void btnAceptarInfo_Click(object sender, EventArgs e)
        {
            if(txtNuevoTel.Text.Length > 1 && txtNuevaDir.Text.Length > 1)
            {
               NuevoTel = txtNuevoTel.Text;
               NuevaDir = txtNuevaDir.Text;
               MessageBox.Show("Los datos se actualizaron correctamente.");
               Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }

        private void ActualizarInfoAlumno_Load(object sender, EventArgs e)
        {
            txtNuevoTel.Text = alumno.Telefono.ToString();
            txtNuevaDir.Text = alumno.Direccion;
        }

        private void btnCancelarInfo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
