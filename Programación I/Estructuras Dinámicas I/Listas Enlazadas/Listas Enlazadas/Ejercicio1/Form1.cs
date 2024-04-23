using System;
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
    public partial class Form1 : Form
    {
        ListaEnlazada Lista = new ListaEnlazada(); 
        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItemALista(Paciente Nodo)
        {
            if(Nodo != null)
            {
                lsbListaCompleta.Items.Add(Nodo.Nombre);
                AgregarItemALista(Nodo.Siguiente);
            }
        }

        public void MostrarLista()
        {
            lsbListaCompleta.Items.Clear();

            if(Lista.Inicio != null)
            {
                AgregarItemALista(Lista.Inicio);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Length > 1)
            {

                Paciente NuevoPaciente = new Paciente(); 

                NuevoPaciente.Nombre = txtNombre.Text;
                Lista.AgregarAlPrincipio(NuevoPaciente);
                MostrarLista();

            }else
            {
                MessageBox.Show("Debe ingresar un nombre.");
            }

        }


    }
}
