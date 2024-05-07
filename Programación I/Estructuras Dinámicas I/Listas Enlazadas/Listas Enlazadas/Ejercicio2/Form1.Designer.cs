namespace Ejercicio2
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarDespues = new System.Windows.Forms.Button();
            this.btnAgregarAntes = new System.Windows.Forms.Button();
            this.lsbListaCompleta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(105, 101);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(188, 41);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar nuevo Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(402, 101);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(188, 41);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar Alumno";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(699, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 41);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Alumno";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarDespues
            // 
            this.btnAgregarDespues.Location = new System.Drawing.Point(699, 622);
            this.btnAgregarDespues.Name = "btnAgregarDespues";
            this.btnAgregarDespues.Size = new System.Drawing.Size(188, 41);
            this.btnAgregarDespues.TabIndex = 4;
            this.btnAgregarDespues.Text = "Agregar después del seleccionado";
            this.btnAgregarDespues.UseVisualStyleBackColor = true;
            this.btnAgregarDespues.Click += new System.EventHandler(this.btnAgregarDespues_Click);
            // 
            // btnAgregarAntes
            // 
            this.btnAgregarAntes.Location = new System.Drawing.Point(126, 622);
            this.btnAgregarAntes.Name = "btnAgregarAntes";
            this.btnAgregarAntes.Size = new System.Drawing.Size(188, 41);
            this.btnAgregarAntes.TabIndex = 5;
            this.btnAgregarAntes.Text = "Agregar antes del seleccionado";
            this.btnAgregarAntes.UseVisualStyleBackColor = true;
            // 
            // lsbListaCompleta
            // 
            this.lsbListaCompleta.FormattingEnabled = true;
            this.lsbListaCompleta.Location = new System.Drawing.Point(77, 157);
            this.lsbListaCompleta.Name = "lsbListaCompleta";
            this.lsbListaCompleta.Size = new System.Drawing.Size(863, 459);
            this.lsbListaCompleta.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 713);
            this.Controls.Add(this.lsbListaCompleta);
            this.Controls.Add(this.btnAgregarAntes);
            this.Controls.Add(this.btnAgregarDespues);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarDespues;
        private System.Windows.Forms.Button btnAgregarAntes;
        public System.Windows.Forms.ListBox lsbListaCompleta;
    }
}

