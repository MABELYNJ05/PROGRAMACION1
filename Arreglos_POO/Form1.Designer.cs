
using System;

namespace Arreglos_POO
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
            this.listBoxResutado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.buttonParcial1 = new System.Windows.Forms.Button();
            this.buttonParcial2 = new System.Windows.Forms.Button();
            this.buttonParcial3 = new System.Windows.Forms.Button();
            this.buttonSumaNotas = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.buttonNotaMin = new System.Windows.Forms.Button();
            this.buttonNotaMax = new System.Windows.Forms.Button();
            this.textBoxSumaNotas = new System.Windows.Forms.TextBox();
            this.textBoxNotaMin = new System.Windows.Forms.TextBox();
            this.textBoxNotaMax = new System.Windows.Forms.TextBox();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxResutado
            // 
            this.listBoxResutado.FormattingEnabled = true;
            this.listBoxResutado.ItemHeight = 16;
            this.listBoxResutado.Location = new System.Drawing.Point(723, 15);
            this.listBoxResutado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxResutado.Name = "listBoxResutado";
            this.listBoxResutado.Size = new System.Drawing.Size(411, 356);
            this.listBoxResutado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(16, 15);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(265, 75);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(289, 15);
            this.textBoxContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(424, 356);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(16, 97);
            this.buttonNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(265, 57);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBoxNotas
            // 
            this.listBoxNotas.FormattingEnabled = true;
            this.listBoxNotas.ItemHeight = 16;
            this.listBoxNotas.Location = new System.Drawing.Point(1143, 15);
            this.listBoxNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxNotas.Name = "listBoxNotas";
            this.listBoxNotas.Size = new System.Drawing.Size(196, 356);
            this.listBoxNotas.TabIndex = 5;
            // 
            // buttonParcial1
            // 
            this.buttonParcial1.Location = new System.Drawing.Point(16, 161);
            this.buttonParcial1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonParcial1.Name = "buttonParcial1";
            this.buttonParcial1.Size = new System.Drawing.Size(265, 55);
            this.buttonParcial1.TabIndex = 6;
            this.buttonParcial1.Text = "Notas Parcial #1";
            this.buttonParcial1.UseVisualStyleBackColor = true;
            this.buttonParcial1.Click += new System.EventHandler(this.buttonParcial1_Click);
            // 
            // buttonParcial2
            // 
            this.buttonParcial2.Location = new System.Drawing.Point(16, 224);
            this.buttonParcial2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonParcial2.Name = "buttonParcial2";
            this.buttonParcial2.Size = new System.Drawing.Size(265, 55);
            this.buttonParcial2.TabIndex = 7;
            this.buttonParcial2.Text = "Notas Parcial #2";
            this.buttonParcial2.UseVisualStyleBackColor = true;
            this.buttonParcial2.Click += new System.EventHandler(this.buttonParcial2_Click);
            // 
            // buttonParcial3
            // 
            this.buttonParcial3.Location = new System.Drawing.Point(16, 287);
            this.buttonParcial3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonParcial3.Name = "buttonParcial3";
            this.buttonParcial3.Size = new System.Drawing.Size(265, 57);
            this.buttonParcial3.TabIndex = 8;
            this.buttonParcial3.Text = "Notas Parcial #3";
            this.buttonParcial3.UseVisualStyleBackColor = true;
            this.buttonParcial3.Click += new System.EventHandler(this.buttonParcial3_Click);
            // 
            // buttonSumaNotas
            // 
            this.buttonSumaNotas.Location = new System.Drawing.Point(955, 399);
            this.buttonSumaNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSumaNotas.Name = "buttonSumaNotas";
            this.buttonSumaNotas.Size = new System.Drawing.Size(180, 43);
            this.buttonSumaNotas.TabIndex = 9;
            this.buttonSumaNotas.Text = "Sumar Notas";
            this.buttonSumaNotas.UseVisualStyleBackColor = true;
            this.buttonSumaNotas.Click += new System.EventHandler(this.buttonSumaNotas_Click);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Location = new System.Drawing.Point(955, 449);
            this.buttonPromedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(180, 42);
            this.buttonPromedio.TabIndex = 10;
            this.buttonPromedio.Text = "Promedio Notas";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // buttonNotaMin
            // 
            this.buttonNotaMin.Location = new System.Drawing.Point(955, 548);
            this.buttonNotaMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNotaMin.Name = "buttonNotaMin";
            this.buttonNotaMin.Size = new System.Drawing.Size(180, 42);
            this.buttonNotaMin.TabIndex = 11;
            this.buttonNotaMin.Text = "Nota Mínima";
            this.buttonNotaMin.UseVisualStyleBackColor = true;
            this.buttonNotaMin.Click += new System.EventHandler(this.buttonNotaMin_Click);
            // 
            // buttonNotaMax
            // 
            this.buttonNotaMax.Location = new System.Drawing.Point(955, 498);
            this.buttonNotaMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNotaMax.Name = "buttonNotaMax";
            this.buttonNotaMax.Size = new System.Drawing.Size(180, 42);
            this.buttonNotaMax.TabIndex = 12;
            this.buttonNotaMax.Text = "Nota Maxíma";
            this.buttonNotaMax.UseVisualStyleBackColor = true;
            this.buttonNotaMax.Click += new System.EventHandler(this.buttonNotaMax_Click);
            // 
            // textBoxSumaNotas
            // 
            this.textBoxSumaNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumaNotas.Location = new System.Drawing.Point(1156, 399);
            this.textBoxSumaNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSumaNotas.Multiline = true;
            this.textBoxSumaNotas.Name = "textBoxSumaNotas";
            this.textBoxSumaNotas.Size = new System.Drawing.Size(171, 42);
            this.textBoxSumaNotas.TabIndex = 13;
            this.textBoxSumaNotas.Text = "SUMA";
            // 
            // textBoxNotaMin
            // 
            this.textBoxNotaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotaMin.Location = new System.Drawing.Point(1156, 546);
            this.textBoxNotaMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNotaMin.Multiline = true;
            this.textBoxNotaMin.Name = "textBoxNotaMin";
            this.textBoxNotaMin.Size = new System.Drawing.Size(171, 42);
            this.textBoxNotaMin.TabIndex = 14;
            this.textBoxNotaMin.Text = "Nota Min";
            // 
            // textBoxNotaMax
            // 
            this.textBoxNotaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotaMax.Location = new System.Drawing.Point(1156, 497);
            this.textBoxNotaMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNotaMax.Multiline = true;
            this.textBoxNotaMax.Name = "textBoxNotaMax";
            this.textBoxNotaMax.Size = new System.Drawing.Size(171, 42);
            this.textBoxNotaMax.TabIndex = 15;
            this.textBoxNotaMax.Text = "Nota Max";
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromedio.Location = new System.Drawing.Point(1156, 448);
            this.textBoxPromedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPromedio.Multiline = true;
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(171, 42);
            this.textBoxPromedio.TabIndex = 16;
            this.textBoxPromedio.Text = "PROMEDIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1356, 620);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.textBoxNotaMax);
            this.Controls.Add(this.textBoxNotaMin);
            this.Controls.Add(this.textBoxSumaNotas);
            this.Controls.Add(this.buttonNotaMax);
            this.Controls.Add(this.buttonNotaMin);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonSumaNotas);
            this.Controls.Add(this.buttonParcial3);
            this.Controls.Add(this.buttonParcial2);
            this.Controls.Add(this.buttonParcial1);
            this.Controls.Add(this.listBoxNotas);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResutado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.ListBox listBoxResutado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.Button buttonParcial1;
        private System.Windows.Forms.Button buttonParcial2;
        private System.Windows.Forms.Button buttonParcial3;
        private System.Windows.Forms.Button buttonSumaNotas;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.Button buttonNotaMin;
        private System.Windows.Forms.Button buttonNotaMax;
        private System.Windows.Forms.TextBox textBoxSumaNotas;
        private System.Windows.Forms.TextBox textBoxNotaMin;
        private System.Windows.Forms.TextBox textBoxNotaMax;
        private System.Windows.Forms.TextBox textBoxPromedio;
    }
}

