﻿namespace Ejercicio2
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarDespues = new System.Windows.Forms.Button();
            this.btnAgregarAntes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(126, 223);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(761, 380);
            this.dgv1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(126, 165);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(188, 41);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar nuevo Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(414, 165);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(188, 41);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar Alumno";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(699, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 41);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Alumno";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDespues
            // 
            this.btnAgregarDespues.Location = new System.Drawing.Point(699, 622);
            this.btnAgregarDespues.Name = "btnAgregarDespues";
            this.btnAgregarDespues.Size = new System.Drawing.Size(188, 41);
            this.btnAgregarDespues.TabIndex = 4;
            this.btnAgregarDespues.Text = "Agregar después del seleccionado";
            this.btnAgregarDespues.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 713);
            this.Controls.Add(this.btnAgregarAntes);
            this.Controls.Add(this.btnAgregarDespues);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarDespues;
        private System.Windows.Forms.Button btnAgregarAntes;
    }
}

