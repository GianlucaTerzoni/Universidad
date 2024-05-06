namespace Ejercicio2
{
    partial class ActualizarInfoAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevoTel = new System.Windows.Forms.TextBox();
            this.txtNuevaDir = new System.Windows.Forms.TextBox();
            this.btnCancelarInfo = new System.Windows.Forms.Button();
            this.btnAceptarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar información de contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // txtNuevoTel
            // 
            this.txtNuevoTel.Location = new System.Drawing.Point(30, 74);
            this.txtNuevoTel.Name = "txtNuevoTel";
            this.txtNuevoTel.Size = new System.Drawing.Size(168, 20);
            this.txtNuevoTel.TabIndex = 3;
            // 
            // txtNuevaDir
            // 
            this.txtNuevaDir.Location = new System.Drawing.Point(33, 131);
            this.txtNuevaDir.Name = "txtNuevaDir";
            this.txtNuevaDir.Size = new System.Drawing.Size(165, 20);
            this.txtNuevaDir.TabIndex = 4;
            // 
            // btnCancelarInfo
            // 
            this.btnCancelarInfo.Location = new System.Drawing.Point(30, 166);
            this.btnCancelarInfo.Name = "btnCancelarInfo";
            this.btnCancelarInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarInfo.TabIndex = 5;
            this.btnCancelarInfo.Text = "Cancelar";
            this.btnCancelarInfo.UseVisualStyleBackColor = true;
            this.btnCancelarInfo.Click += new System.EventHandler(this.btnCancelarInfo_Click);
            // 
            // btnAceptarInfo
            // 
            this.btnAceptarInfo.Location = new System.Drawing.Point(123, 166);
            this.btnAceptarInfo.Name = "btnAceptarInfo";
            this.btnAceptarInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarInfo.TabIndex = 6;
            this.btnAceptarInfo.Text = "Aceptar";
            this.btnAceptarInfo.UseVisualStyleBackColor = true;
            this.btnAceptarInfo.Click += new System.EventHandler(this.btnAceptarInfo_Click);
            // 
            // ActualizarInfoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 223);
            this.Controls.Add(this.btnAceptarInfo);
            this.Controls.Add(this.btnCancelarInfo);
            this.Controls.Add(this.txtNuevaDir);
            this.Controls.Add(this.txtNuevoTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarInfoAlumno";
            this.Text = "ActualizarInfoAlumno";
            this.Load += new System.EventHandler(this.ActualizarInfoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevoTel;
        private System.Windows.Forms.TextBox txtNuevaDir;
        private System.Windows.Forms.Button btnCancelarInfo;
        private System.Windows.Forms.Button btnAceptarInfo;
    }
}