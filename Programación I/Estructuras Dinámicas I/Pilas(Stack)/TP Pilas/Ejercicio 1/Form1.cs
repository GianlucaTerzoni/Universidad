using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{

    public partial class Form1 : Form
    {
        Pila PilaPrincipal = new Pila();
        Pila PilaSecundaria = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarPilaPrincipal()
        {
            lsbPrincipal.Items.Clear();

            if(PilaPrincipal.Tope()!= null)
            {
            MostrarNodoEnLista(PilaPrincipal.Tope());
            }
        }

        public void MostrarNodoEnLista(Contenedor contenedor)
        {
            lsbPrincipal.Items.Add(contenedor.NumeroDeIdentificacion);

            if(contenedor.Siguiente != null)
            {
                MostrarNodoEnLista(contenedor.Siguiente);
            }
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            Contenedor nuevoContenedor = new Contenedor();

            if(txtIdentificador.Text.Length > 0)
            {               
                nuevoContenedor.NumeroDeIdentificacion = txtIdentificador.Text;
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de identificación.");
            }
            PilaPrincipal.Push(nuevoContenedor);
            MostrarPilaPrincipal();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            PilaPrincipal.Pop();
            MostrarPilaPrincipal();
        }
    }
}
