using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        Cola ColaImpresora = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHPOne_Click(object sender, EventArgs e)
        {
            AgregarImpresion("HP One");
        }

        private void btnIBM_Click(object sender, EventArgs e)
        {
            AgregarImpresion("IBM Full Color");
        }

        private void btnXEROX_Click(object sender, EventArgs e)
        {
            AgregarImpresion("XEROX Print");
        }

        private void btnHPTL1_Click(object sender, EventArgs e)
        {
            AgregarImpresion("HP TL-1");
        }

        private void AgregarImpresion(string modelo)
        {
            if (txtCantidadDeCopias.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar la cantidad de copias requeridas.");
            }
            if (!int.TryParse(txtCantidadDeCopias.Text, out int copiasImpresion))
            {
                MessageBox.Show("Debe ingresar un número válido para la cantidad de copias.");
                return;
            }

            Impresora nuevaPeticion = new Impresora();
            nuevaPeticion.Modelo = modelo;
            nuevaPeticion.Copias = copiasImpresion;
            ColaImpresora.Encolar(nuevaPeticion);


            txtCantidadDeCopias.Text = "";
            MostrarListaCompleta();
        }

        private void MostrarListaCompleta()
        {
            lsbImprimir.Items.Clear();
            MostrarNodoEnPantalla(ColaImpresora.Inicio);
        }

        private void MostrarNodoEnPantalla(Impresora Nodo)
        {
            if(Nodo != null)
            {
                //lsbImprimir.Items.Add(Nodo.Modelo);
                lsbImprimir.Items.Add($"{Nodo.Modelo} -  Copias: {Nodo.Copias}");

                if (Nodo.Siguiente != null)
                {      
                    MostrarNodoEnPantalla(Nodo.Siguiente);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ColaImpresora.Vacia())
            {
                MessageBox.Show("La cola está vacía");
            }
            else
            {
                ColaImpresora.Desencolar();
                MostrarListaCompleta();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {           
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar el programa?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(respuesta == DialogResult.Yes)
            {
                 Close();
            }
        }
    }
}
