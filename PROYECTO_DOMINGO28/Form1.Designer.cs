
namespace PROYECTO_DOMINGO28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CrearVehículoButton = new System.Windows.Forms.Button();
            this.EncenderButton = new System.Windows.Forms.Button();
            this.AcelerarButton = new System.Windows.Forms.Button();
            this.FrenarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.REPRODUCTOR = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Aleatorio = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pausa = new System.Windows.Forms.PictureBox();
            this.Deterner = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.REPRODUCTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deterner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearVehículoButton
            // 
            this.CrearVehículoButton.BackColor = System.Drawing.Color.Black;
            this.CrearVehículoButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearVehículoButton.ForeColor = System.Drawing.Color.Transparent;
            this.CrearVehículoButton.Location = new System.Drawing.Point(81, 35);
            this.CrearVehículoButton.Name = "CrearVehículoButton";
            this.CrearVehículoButton.Size = new System.Drawing.Size(192, 64);
            this.CrearVehículoButton.TabIndex = 0;
            this.CrearVehículoButton.Text = "CREAR VEHÍCULO";
            this.CrearVehículoButton.UseVisualStyleBackColor = false;
            this.CrearVehículoButton.Click += new System.EventHandler(this.CrearVehículoButton_Click);
            // 
            // EncenderButton
            // 
            this.EncenderButton.BackColor = System.Drawing.Color.Green;
            this.EncenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncenderButton.Location = new System.Drawing.Point(114, 123);
            this.EncenderButton.Name = "EncenderButton";
            this.EncenderButton.Size = new System.Drawing.Size(134, 48);
            this.EncenderButton.TabIndex = 1;
            this.EncenderButton.Text = "ENCENDER \r\nVEHÍCULO";
            this.EncenderButton.UseVisualStyleBackColor = false;
            this.EncenderButton.Click += new System.EventHandler(this.EncenderButton_Click);
            // 
            // AcelerarButton
            // 
            this.AcelerarButton.BackColor = System.Drawing.Color.Yellow;
            this.AcelerarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcelerarButton.Location = new System.Drawing.Point(377, 188);
            this.AcelerarButton.Name = "AcelerarButton";
            this.AcelerarButton.Size = new System.Drawing.Size(134, 48);
            this.AcelerarButton.TabIndex = 2;
            this.AcelerarButton.Text = "ACELERAR";
            this.AcelerarButton.UseVisualStyleBackColor = false;
            this.AcelerarButton.Click += new System.EventHandler(this.AcelerarButton_Click);
            // 
            // FrenarButton
            // 
            this.FrenarButton.BackColor = System.Drawing.Color.Yellow;
            this.FrenarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrenarButton.Location = new System.Drawing.Point(377, 275);
            this.FrenarButton.Name = "FrenarButton";
            this.FrenarButton.Size = new System.Drawing.Size(134, 48);
            this.FrenarButton.TabIndex = 3;
            this.FrenarButton.Text = "FRENAR ";
            this.FrenarButton.UseVisualStyleBackColor = false;
            this.FrenarButton.Click += new System.EventHandler(this.FrenarButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(377, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "LIMPIAR VIDRIOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "0km/h";
            // 
            // REPRODUCTOR
            // 
            this.REPRODUCTOR.Enabled = true;
            this.REPRODUCTOR.Location = new System.Drawing.Point(558, 187);
            this.REPRODUCTOR.Name = "REPRODUCTOR";
            this.REPRODUCTOR.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("REPRODUCTOR.OcxState")));
            this.REPRODUCTOR.Size = new System.Drawing.Size(230, 49);
            this.REPRODUCTOR.TabIndex = 9;
            // 
            // Play
            // 
            this.Play.Image = global::PROYECTO_DOMINGO28.Properties.Resources.PLAY;
            this.Play.Location = new System.Drawing.Point(558, 242);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(52, 47);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 12;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Aleatorio
            // 
            this.Aleatorio.Image = global::PROYECTO_DOMINGO28.Properties.Resources.ALEATORIO;
            this.Aleatorio.Location = new System.Drawing.Point(678, 242);
            this.Aleatorio.Name = "Aleatorio";
            this.Aleatorio.Size = new System.Drawing.Size(52, 47);
            this.Aleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aleatorio.TabIndex = 11;
            this.Aleatorio.TabStop = false;
            this.Aleatorio.Click += new System.EventHandler(this.Aleatorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_DOMINGO28.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(21, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Pausa
            // 
            this.Pausa.Image = global::PROYECTO_DOMINGO28.Properties.Resources.pausa;
            this.Pausa.Location = new System.Drawing.Point(618, 242);
            this.Pausa.Name = "Pausa";
            this.Pausa.Size = new System.Drawing.Size(52, 47);
            this.Pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pausa.TabIndex = 14;
            this.Pausa.TabStop = false;
            this.Pausa.Click += new System.EventHandler(this.Pausa_Click);
            // 
            // Deterner
            // 
            this.Deterner.Image = global::PROYECTO_DOMINGO28.Properties.Resources.detener;
            this.Deterner.Location = new System.Drawing.Point(736, 242);
            this.Deterner.Name = "Deterner";
            this.Deterner.Size = new System.Drawing.Size(52, 47);
            this.Deterner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Deterner.TabIndex = 15;
            this.Deterner.TabStop = false;
            this.Deterner.Click += new System.EventHandler(this.Deterner_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROYECTO_DOMINGO28.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(558, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Deterner);
            this.Controls.Add(this.Pausa);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Aleatorio);
            this.Controls.Add(this.REPRODUCTOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FrenarButton);
            this.Controls.Add(this.AcelerarButton);
            this.Controls.Add(this.EncenderButton);
            this.Controls.Add(this.CrearVehículoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.REPRODUCTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deterner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CrearVehículoButton;
        private System.Windows.Forms.Button EncenderButton;
        private System.Windows.Forms.Button AcelerarButton;
        private System.Windows.Forms.Button FrenarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer REPRODUCTOR;
        private System.Windows.Forms.PictureBox Aleatorio;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Pausa;
        private System.Windows.Forms.PictureBox Deterner;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

