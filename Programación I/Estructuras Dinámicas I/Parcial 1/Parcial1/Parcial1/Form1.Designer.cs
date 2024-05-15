namespace Parcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbImprimir = new System.Windows.Forms.ListBox();
            this.gbImpresoras = new System.Windows.Forms.GroupBox();
            this.btnHPTL1 = new System.Windows.Forms.Button();
            this.btnXEROX = new System.Windows.Forms.Button();
            this.btnIBM = new System.Windows.Forms.Button();
            this.btnHPOne = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCantidadDeCopias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbImpresoras.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbImprimir
            // 
            this.lsbImprimir.FormattingEnabled = true;
            this.lsbImprimir.Location = new System.Drawing.Point(24, 240);
            this.lsbImprimir.Name = "lsbImprimir";
            this.lsbImprimir.Size = new System.Drawing.Size(658, 225);
            this.lsbImprimir.TabIndex = 0;
            // 
            // gbImpresoras
            // 
            this.gbImpresoras.Controls.Add(this.btnHPTL1);
            this.gbImpresoras.Controls.Add(this.btnXEROX);
            this.gbImpresoras.Controls.Add(this.btnIBM);
            this.gbImpresoras.Controls.Add(this.btnHPOne);
            this.gbImpresoras.Location = new System.Drawing.Point(24, 22);
            this.gbImpresoras.Name = "gbImpresoras";
            this.gbImpresoras.Size = new System.Drawing.Size(658, 89);
            this.gbImpresoras.TabIndex = 1;
            this.gbImpresoras.TabStop = false;
            this.gbImpresoras.Text = "Impresoras";
            // 
            // btnHPTL1
            // 
            this.btnHPTL1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHPTL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHPTL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHPTL1.Location = new System.Drawing.Point(501, 42);
            this.btnHPTL1.Name = "btnHPTL1";
            this.btnHPTL1.Size = new System.Drawing.Size(127, 29);
            this.btnHPTL1.TabIndex = 3;
            this.btnHPTL1.Text = "HP TL-1";
            this.btnHPTL1.UseVisualStyleBackColor = false;
            this.btnHPTL1.Click += new System.EventHandler(this.btnHPTL1_Click);
            // 
            // btnXEROX
            // 
            this.btnXEROX.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXEROX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXEROX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXEROX.Location = new System.Drawing.Point(344, 42);
            this.btnXEROX.Name = "btnXEROX";
            this.btnXEROX.Size = new System.Drawing.Size(127, 29);
            this.btnXEROX.TabIndex = 2;
            this.btnXEROX.Text = "XEROX Print";
            this.btnXEROX.UseVisualStyleBackColor = false;
            this.btnXEROX.Click += new System.EventHandler(this.btnXEROX_Click);
            // 
            // btnIBM
            // 
            this.btnIBM.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIBM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIBM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIBM.Location = new System.Drawing.Point(190, 42);
            this.btnIBM.Name = "btnIBM";
            this.btnIBM.Size = new System.Drawing.Size(127, 29);
            this.btnIBM.TabIndex = 1;
            this.btnIBM.Text = "IBM Full Color";
            this.btnIBM.UseVisualStyleBackColor = false;
            this.btnIBM.Click += new System.EventHandler(this.btnIBM_Click);
            // 
            // btnHPOne
            // 
            this.btnHPOne.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHPOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHPOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHPOne.Location = new System.Drawing.Point(30, 42);
            this.btnHPOne.Name = "btnHPOne";
            this.btnHPOne.Size = new System.Drawing.Size(127, 29);
            this.btnHPOne.TabIndex = 0;
            this.btnHPOne.Text = "HP One";
            this.btnHPOne.UseVisualStyleBackColor = false;
            this.btnHPOne.Click += new System.EventHandler(this.btnHPOne_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnImprimir);
            this.gbAcciones.Controls.Add(this.btnSalir);
            this.gbAcciones.Controls.Add(this.txtCantidadDeCopias);
            this.gbAcciones.Controls.Add(this.label1);
            this.gbAcciones.Location = new System.Drawing.Point(24, 146);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(658, 68);
            this.gbAcciones.TabIndex = 2;
            this.gbAcciones.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(513, 25);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 29);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(380, 25);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCantidadDeCopias
            // 
            this.txtCantidadDeCopias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadDeCopias.Location = new System.Drawing.Point(207, 25);
            this.txtCantidadDeCopias.Multiline = true;
            this.txtCantidadDeCopias.Name = "txtCantidadDeCopias";
            this.txtCantidadDeCopias.Size = new System.Drawing.Size(110, 29);
            this.txtCantidadDeCopias.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Copias:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 489);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbImpresoras);
            this.Controls.Add(this.lsbImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbImpresoras.ResumeLayout(false);
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbImprimir;
        private System.Windows.Forms.GroupBox gbImpresoras;
        private System.Windows.Forms.Button btnHPTL1;
        private System.Windows.Forms.Button btnXEROX;
        private System.Windows.Forms.Button btnIBM;
        private System.Windows.Forms.Button btnHPOne;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.TextBox txtCantidadDeCopias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
    }
}

