namespace Ejercicio_1
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
            this.lsbPrincipal = new System.Windows.Forms.ListBox();
            this.lsbSecundario = new System.Windows.Forms.ListBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApilar = new System.Windows.Forms.Button();
            this.btnMoverSecundario = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnMoverPrincipal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbPrincipal
            // 
            this.lsbPrincipal.FormattingEnabled = true;
            this.lsbPrincipal.Location = new System.Drawing.Point(218, 85);
            this.lsbPrincipal.Name = "lsbPrincipal";
            this.lsbPrincipal.Size = new System.Drawing.Size(139, 238);
            this.lsbPrincipal.TabIndex = 0;
            // 
            // lsbSecundario
            // 
            this.lsbSecundario.FormattingEnabled = true;
            this.lsbSecundario.Location = new System.Drawing.Point(402, 85);
            this.lsbSecundario.Name = "lsbSecundario";
            this.lsbSecundario.Size = new System.Drawing.Size(139, 238);
            this.lsbSecundario.TabIndex = 1;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(51, 101);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(140, 20);
            this.txtIdentificador.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Identificación:";
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(51, 127);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(140, 30);
            this.btnApilar.TabIndex = 4;
            this.btnApilar.Text = "Apilar Contenedor";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // btnMoverSecundario
            // 
            this.btnMoverSecundario.Location = new System.Drawing.Point(51, 198);
            this.btnMoverSecundario.Name = "btnMoverSecundario";
            this.btnMoverSecundario.Size = new System.Drawing.Size(140, 39);
            this.btnMoverSecundario.TabIndex = 5;
            this.btnMoverSecundario.Text = "Mover Contenedor hacia la pila secundaria";
            this.btnMoverSecundario.UseVisualStyleBackColor = true;
            this.btnMoverSecundario.Click += new System.EventHandler(this.btnMoverSecundario_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(51, 163);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(140, 29);
            this.btnDesapilar.TabIndex = 6;
            this.btnDesapilar.Text = "Desapilar Contenedor";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnMoverPrincipal
            // 
            this.btnMoverPrincipal.Location = new System.Drawing.Point(51, 243);
            this.btnMoverPrincipal.Name = "btnMoverPrincipal";
            this.btnMoverPrincipal.Size = new System.Drawing.Size(140, 38);
            this.btnMoverPrincipal.TabIndex = 7;
            this.btnMoverPrincipal.Text = "Mover Contenedor hacia la pila principal";
            this.btnMoverPrincipal.UseVisualStyleBackColor = true;
            this.btnMoverPrincipal.Click += new System.EventHandler(this.btnMoverPrincipal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pila Principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pila Secundaria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoverPrincipal);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnMoverSecundario);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.lsbSecundario);
            this.Controls.Add(this.lsbPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPrincipal;
        private System.Windows.Forms.ListBox lsbSecundario;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.Button btnMoverSecundario;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnMoverPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

