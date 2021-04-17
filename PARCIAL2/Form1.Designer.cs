
namespace PARCIAL2
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonParcial1 = new System.Windows.Forms.Button();
            this.buttonParcial2 = new System.Windows.Forms.Button();
            this.buttonParcial3 = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.buttonSeccionC = new System.Windows.Forms.Button();
            this.buttonSeccionB = new System.Windows.Forms.Button();
            this.buttonSeccionA = new System.Windows.Forms.Button();
            this.listBoxSección = new System.Windows.Forms.ListBox();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.textBoxPromedioxSeccion = new System.Windows.Forms.TextBox();
            this.buttonPGS = new System.Windows.Forms.Button();
            this.textBoxPGS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(2, 11);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(106, 59);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click_1);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(2, 76);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(106, 34);
            this.buttonNombres.TabIndex = 1;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonParcial1
            // 
            this.buttonParcial1.Location = new System.Drawing.Point(2, 301);
            this.buttonParcial1.Name = "buttonParcial1";
            this.buttonParcial1.Size = new System.Drawing.Size(106, 51);
            this.buttonParcial1.TabIndex = 2;
            this.buttonParcial1.Text = "Parcial #1";
            this.buttonParcial1.UseVisualStyleBackColor = true;
            this.buttonParcial1.Click += new System.EventHandler(this.buttonParcial1_Click);
            // 
            // buttonParcial2
            // 
            this.buttonParcial2.Location = new System.Drawing.Point(2, 377);
            this.buttonParcial2.Name = "buttonParcial2";
            this.buttonParcial2.Size = new System.Drawing.Size(106, 53);
            this.buttonParcial2.TabIndex = 3;
            this.buttonParcial2.Text = "Parcial #2";
            this.buttonParcial2.UseVisualStyleBackColor = true;
            this.buttonParcial2.Click += new System.EventHandler(this.buttonParcial2_Click);
            // 
            // buttonParcial3
            // 
            this.buttonParcial3.Location = new System.Drawing.Point(2, 456);
            this.buttonParcial3.Name = "buttonParcial3";
            this.buttonParcial3.Size = new System.Drawing.Size(106, 53);
            this.buttonParcial3.TabIndex = 4;
            this.buttonParcial3.Text = "Parcial #3";
            this.buttonParcial3.UseVisualStyleBackColor = true;
            this.buttonParcial3.Click += new System.EventHandler(this.buttonParcial3_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(712, 436);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(135, 41);
            this.buttonMax.TabIndex = 7;
            this.buttonMax.Text = "Nota Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(712, 483);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(135, 41);
            this.buttonMin.TabIndex = 8;
            this.buttonMin.Text = "Nota Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(124, 11);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(264, 498);
            this.textBoxContenido.TabIndex = 9;
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.Location = new System.Drawing.Point(394, 11);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(276, 290);
            this.listBoxNombres.TabIndex = 13;
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.Location = new System.Drawing.Point(923, 11);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(67, 290);
            this.listBoxResultados.TabIndex = 14;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(866, 483);
            this.textBoxMin.Multiline = true;
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(124, 41);
            this.textBoxMin.TabIndex = 16;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(866, 436);
            this.textBoxMax.Multiline = true;
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(124, 41);
            this.textBoxMax.TabIndex = 17;
            // 
            // buttonSeccionC
            // 
            this.buttonSeccionC.Location = new System.Drawing.Point(2, 242);
            this.buttonSeccionC.Name = "buttonSeccionC";
            this.buttonSeccionC.Size = new System.Drawing.Size(106, 34);
            this.buttonSeccionC.TabIndex = 18;
            this.buttonSeccionC.Text = "Sección C";
            this.buttonSeccionC.UseVisualStyleBackColor = true;
            this.buttonSeccionC.Click += new System.EventHandler(this.buttonSeccionC_Click);
            // 
            // buttonSeccionB
            // 
            this.buttonSeccionB.Location = new System.Drawing.Point(2, 185);
            this.buttonSeccionB.Name = "buttonSeccionB";
            this.buttonSeccionB.Size = new System.Drawing.Size(106, 34);
            this.buttonSeccionB.TabIndex = 19;
            this.buttonSeccionB.Text = "Sección B";
            this.buttonSeccionB.UseVisualStyleBackColor = true;
            this.buttonSeccionB.Click += new System.EventHandler(this.buttonSeccionB_Click);
            // 
            // buttonSeccionA
            // 
            this.buttonSeccionA.Location = new System.Drawing.Point(2, 129);
            this.buttonSeccionA.Name = "buttonSeccionA";
            this.buttonSeccionA.Size = new System.Drawing.Size(106, 34);
            this.buttonSeccionA.TabIndex = 20;
            this.buttonSeccionA.Text = "Sección A";
            this.buttonSeccionA.UseVisualStyleBackColor = true;
            this.buttonSeccionA.Click += new System.EventHandler(this.buttonSeccionA_Click);
            // 
            // listBoxSección
            // 
            this.listBoxSección.FormattingEnabled = true;
            this.listBoxSección.Location = new System.Drawing.Point(676, 12);
            this.listBoxSección.Name = "listBoxSección";
            this.listBoxSección.Size = new System.Drawing.Size(241, 290);
            this.listBoxSección.TabIndex = 21;
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Location = new System.Drawing.Point(712, 389);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(135, 41);
            this.buttonPromedio.TabIndex = 6;
            this.buttonPromedio.Text = "Promedio por Sección";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // textBoxPromedioxSeccion
            // 
            this.textBoxPromedioxSeccion.Location = new System.Drawing.Point(866, 389);
            this.textBoxPromedioxSeccion.Multiline = true;
            this.textBoxPromedioxSeccion.Name = "textBoxPromedioxSeccion";
            this.textBoxPromedioxSeccion.Size = new System.Drawing.Size(124, 41);
            this.textBoxPromedioxSeccion.TabIndex = 15;
            // 
            // buttonPGS
            // 
            this.buttonPGS.Location = new System.Drawing.Point(491, 307);
            this.buttonPGS.Name = "buttonPGS";
            this.buttonPGS.Size = new System.Drawing.Size(135, 41);
            this.buttonPGS.TabIndex = 22;
            this.buttonPGS.Text = "Promedios Generales por Sección";
            this.buttonPGS.UseVisualStyleBackColor = true;
            this.buttonPGS.Click += new System.EventHandler(this.buttonPGS_Click);
            // 
            // textBoxPGS
            // 
            this.textBoxPGS.Location = new System.Drawing.Point(394, 354);
            this.textBoxPGS.Multiline = true;
            this.textBoxPGS.Name = "textBoxPGS";
            this.textBoxPGS.Size = new System.Drawing.Size(312, 170);
            this.textBoxPGS.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 535);
            this.Controls.Add(this.textBoxPGS);
            this.Controls.Add(this.buttonPGS);
            this.Controls.Add(this.listBoxSección);
            this.Controls.Add(this.buttonSeccionA);
            this.Controls.Add(this.buttonSeccionB);
            this.Controls.Add(this.buttonSeccionC);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxPromedioxSeccion);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonParcial3);
            this.Controls.Add(this.buttonParcial2);
            this.Controls.Add(this.buttonParcial1);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonParcial1;
        private System.Windows.Forms.Button buttonParcial2;
        private System.Windows.Forms.Button buttonParcial3;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.ListBox listBoxResultados;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonSeccionC;
        private System.Windows.Forms.Button buttonSeccionB;
        private System.Windows.Forms.Button buttonSeccionA;
        private System.Windows.Forms.ListBox listBoxSección;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.TextBox textBoxPromedioxSeccion;
        private System.Windows.Forms.Button buttonPGS;
        private System.Windows.Forms.TextBox textBoxPGS;
    }
}

