namespace FarmaExpend.RaspForm
{
    partial class frmProductos
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
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.pbSeleccionado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.p1Precio = new System.Windows.Forms.Label();
            this.p2Precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(51, 40);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(141, 91);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(286, 40);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(141, 91);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // pbSeleccionado
            // 
            this.pbSeleccionado.Location = new System.Drawing.Point(172, 190);
            this.pbSeleccionado.Name = "pbSeleccionado";
            this.pbSeleccionado.Size = new System.Drawing.Size(141, 91);
            this.pbSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSeleccionado.TabIndex = 2;
            this.pbSeleccionado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionado";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(344, 218);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(83, 41);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // p1Precio
            // 
            this.p1Precio.AutoSize = true;
            this.p1Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Precio.Location = new System.Drawing.Point(92, 134);
            this.p1Precio.Name = "p1Precio";
            this.p1Precio.Size = new System.Drawing.Size(59, 20);
            this.p1Precio.TabIndex = 5;
            this.p1Precio.Text = "Precio";
            // 
            // p2Precio
            // 
            this.p2Precio.AutoSize = true;
            this.p2Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Precio.Location = new System.Drawing.Point(331, 134);
            this.p2Precio.Name = "p2Precio";
            this.p2Precio.Size = new System.Drawing.Size(59, 20);
            this.p2Precio.TabIndex = 6;
            this.p2Precio.Text = "Precio";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.p2Precio);
            this.Controls.Add(this.p1Precio);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSeleccionado);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox pbSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label p1Precio;
        private System.Windows.Forms.Label p2Precio;
    }
}