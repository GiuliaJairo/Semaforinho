namespace Semaforinho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLigar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pibFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLigar.Location = new System.Drawing.Point(308, 513);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(179, 44);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pibFoto
            // 
            this.pibFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibFoto.Image = global::Semaforinho.Properties.Resources.apagado;
            this.pibFoto.Location = new System.Drawing.Point(221, 93);
            this.pibFoto.Name = "pibFoto";
            this.pibFoto.Size = new System.Drawing.Size(355, 391);
            this.pibFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibFoto.TabIndex = 0;
            this.pibFoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.pibFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pibFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibFoto;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Timer timer;
    }
}

