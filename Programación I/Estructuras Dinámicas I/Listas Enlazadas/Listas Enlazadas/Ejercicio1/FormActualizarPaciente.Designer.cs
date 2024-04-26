namespace Ejercicio1
{
    partial class FormActualizarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptarMod = new System.Windows.Forms.Button();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptarMod
            // 
            this.btnAceptarMod.Location = new System.Drawing.Point(116, 95);
            this.btnAceptarMod.Name = "btnAceptarMod";
            this.btnAceptarMod.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMod.TabIndex = 0;
            this.btnAceptarMod.Text = "Aceptar";
            this.btnAceptarMod.UseVisualStyleBackColor = true;
            this.btnAceptarMod.Click += new System.EventHandler(this.btnAceptarMod_Click);
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(21, 95);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMod.TabIndex = 1;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Location = new System.Drawing.Point(27, 29);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(93, 13);
            this.lblModNombre.TabIndex = 2;
            this.lblModNombre.Text = "Modificar Nombre:";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(21, 59);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(170, 20);
            this.txtModNombre.TabIndex = 3;
            // 
            // FormActualizarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 170);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.lblModNombre);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnAceptarMod);
            this.Name = "FormActualizarPaciente";
            this.Text = "FormActualizarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.TextBox txtModNombre;
    }
}