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

namespace Ejercicio1
{
    public partial class FormActualizarPaciente : Form
    {
        public string NuevoNombre { get; private set; }
        public FormActualizarPaciente()
        {
            InitializeComponent();
        }

        private void btnAceptarMod_Click(object sender, EventArgs e)
        {

            if (txtModNombre.Text.Length > 0)
            {
                NuevoNombre = txtModNombre.Text;
                MessageBox.Show("El nombre se actualizó correctamente.");
                Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }

        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
