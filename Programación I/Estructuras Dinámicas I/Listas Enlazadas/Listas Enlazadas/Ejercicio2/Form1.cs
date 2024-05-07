using System;
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


    public partial class Form1 : Form
    {
        ListaEnlazada Lista = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();

        }

        public void AgregarItemALaLista(Alumno nuevoAlumno)
        {
            if (nuevoAlumno != null)
            {
                lsbListaCompleta.Items.Add(nuevoAlumno);
                AgregarItemALaLista(nuevoAlumno.Siguiente);
            }
        }

        public void MostrarLista()
        {
            lsbListaCompleta.Items.Clear();
            var alumnos = Lista.GetAlumnos();

            lsbListaCompleta.Items.AddRange(alumnos.ToArray());

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarAlumno registrar = new FormRegistrarAlumno(Lista);
            registrar.ShowDialog(this);
            MostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsbListaCompleta.SelectedItem != null)
            {
                if (lsbListaCompleta.SelectedItem is Alumno alumnoSeleccionado)
                {
                    int indiceSeleccionado = lsbListaCompleta.SelectedIndex;

                    Lista.EliminarAlumno(alumnoSeleccionado);
                    MostrarLista();

                    if (indiceSeleccionado >= 0 && indiceSeleccionado < lsbListaCompleta.Items.Count)
                    {
                        lsbListaCompleta.SetSelected(indiceSeleccionado, true);
                    }
                }
                else
                {
                    MessageBox.Show("El elemento seleccionado no es un alumno.");
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
                if (lsbListaCompleta.SelectedItem is Alumno alumnoSeleccionado)
                {

                    int indiceSeleccionado = lsbListaCompleta.SelectedIndex;

                    ActualizarInfoAlumno actualizar = new ActualizarInfoAlumno(alumnoSeleccionado);
                    actualizar.ShowDialog();

                    decimal telNuevo = Convert.ToDecimal(actualizar.NuevoTel);
                    alumnoSeleccionado.Telefono = telNuevo;

                    alumnoSeleccionado.Direccion = actualizar.NuevaDir;
                    MostrarLista();

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún paciente.");
                }
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            if(lsbListaCompleta.SelectedItem != null)
            {
                if (lsbListaCompleta.SelectedItem is Alumno alumnoSeleccionado)
                {
                    int indiceSeleccionado = lsbListaCompleta.SelectedIndex;

                    FormAgregarDespuesDelSeleccionado registroDespuesSeleccionado = new FormAgregarDespuesDelSeleccionado(Lista,this);
                    registroDespuesSeleccionado.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un alumno.");
                }
            }
        }

        private void btnAgregarAntes_Click(object sender, EventArgs e)
        {
            if (lsbListaCompleta.SelectedItem != null)
            {
                if (lsbListaCompleta.SelectedItem is Alumno alumnoSeleccionado)
                {
                    int indiceSeleccionado = lsbListaCompleta.SelectedIndex;

                    FormAgregarAntes registroAntesSeleccionado = new FormAgregarAntes(Lista, this);
                    registroAntesSeleccionado.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un alumno.");
                }
            }
        }
    }
}
