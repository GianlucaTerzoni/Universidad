using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            if (Nodo != null)
            {
                
                lsbListaCompleta.Items.Add(Nodo.Nombre);
                AgregarItemALista(Nodo.Siguiente);
            }


        }

        public void MostrarLista()
        {

            lsbListaCompleta.Items.Clear();

            var pacientes = Lista.getPacientes();
            lsbListaCompleta.Items.AddRange(pacientes.ToArray());

            lsbListaCompleta.DisplayMember = "Nombre";

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Length > 1)
            {

                Paciente NuevoPaciente = new Paciente();

                NuevoPaciente.Nombre = txtNombre.Text;
                Lista.AgregarAlPrincipio(NuevoPaciente);
                MostrarLista();

            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Lista.Inicio == null)
            {
                MessageBox.Show("La lista está vacía.");
            }
            else
            {
                Lista.EliminarSeleccionado(Lista.Inicio);
            }

            MostrarLista();

        }



        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {

            if (lsbListaCompleta.SelectedItem != null)
            {
                if (lsbListaCompleta.SelectedItem is Paciente pacienteSeleccionado)
                {
                    int indiceSeleccionado = lsbListaCompleta.SelectedIndex; 

                    Lista.EliminarSeleccionado(pacienteSeleccionado);
                    MostrarLista();


                    if (indiceSeleccionado >= 0 && indiceSeleccionado < lsbListaCompleta.Items.Count)
                    {
                        lsbListaCompleta.SetSelected(indiceSeleccionado, true);
                    }
                }
                else
                {
                    MessageBox.Show("El elemento seleccionado no es un paciente.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún elemento.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            if (lsbListaCompleta.SelectedItem != null)
            {
                if (lsbListaCompleta.SelectedItem is Paciente pacienteSeleccionado)
                {

                    int indiceSeleccionado = lsbListaCompleta.SelectedIndex;

                    FormActualizarPaciente actualizar = new FormActualizarPaciente();
                    actualizar.ShowDialog();



                    if (!string.IsNullOrEmpty(actualizar.NuevoNombre))
                    {
                        pacienteSeleccionado.Nombre = actualizar.NuevoNombre;
                        MostrarLista();
                    }
                }
                else
                {
                    MessageBox.Show("El elemento seleccionado no es un paciente.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún paciente.");
            }

        }
    }
}
