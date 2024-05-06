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

            //foreach (var alumno in alumnos)
            //{
            //    string infoAlumno = $"NOMBRE: {alumno.Nombre}, APELLIDO: {alumno.Apellido}, DNI: {alumno.Dni}, FECHA DE NACIMIENTO {alumno.FechaDeNacimiento}, DIRECCIÓN: {alumno.Direccion}, TELÉFONO: {alumno.Telefono}";
            //    lsbListaCompleta.Items.Add(infoAlumno);
            //}
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
    }
}
