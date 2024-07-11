using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lsbComprobantes.Items.Clear();

            string filePathCabecera = "CABECERA.txt.txt";
            string filePathDetalle = "DETALLE.txt.txt";

            
            string[] vectorCabecera = new string[0];
            string[] vectorDetalle = new string[0];
            string nroComprobanteCabecera, razonSocial, fecha, nroComprobanteDetalle, descripcion;



            try
            {
                using (StreamReader srCabecera = new StreamReader(filePathCabecera))
                {
                    string lineaCabecera;
                    srCabecera.ReadLine(); 

                    while ((lineaCabecera = srCabecera.ReadLine()) != null)
                    {
                        vectorCabecera = lineaCabecera.Split(';');
                        nroComprobanteCabecera = vectorCabecera[0];
                        razonSocial = vectorCabecera[1];
                        fecha = vectorCabecera[2];

                        lsbComprobantes.Items.Add($"Nro Comprobante: {nroComprobanteCabecera}");
                        lsbComprobantes.Items.Add($"Razón Social: {razonSocial}");
                        lsbComprobantes.Items.Add($"Fecha: {fecha}");

                        //Muestro solo el encabezado del archivo CABECERA

                        float montoTotal = 0;

                        using (StreamReader srDetalle = new StreamReader(filePathDetalle))
                        {
                            string lineaDetalle;
                            srDetalle.ReadLine(); 

                            while ((lineaDetalle = srDetalle.ReadLine()) != null)
                            {
                                vectorDetalle = lineaDetalle.Split(';');
                                nroComprobanteDetalle = vectorDetalle[0];

                                if (nroComprobanteCabecera == nroComprobanteDetalle)
                                {
                                    descripcion = vectorDetalle[1];
                                    var importe = float.Parse(vectorDetalle[2]);

                                    lsbComprobantes.Items.Add($"  {descripcion}: {importe:C}");
                                    montoTotal += importe;
                                }
                            }
                        }

                        lsbComprobantes.Items.Add($"TOTAL: {montoTotal:C}");
                        lsbComprobantes.Items.Add(""); 
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                lsbComprobantes.Items.Add("El archivo no se encontró: " + ex.Message);
            }
            catch (Exception ex)
            {
                lsbComprobantes.Items.Add("Se produjo un error: " + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
