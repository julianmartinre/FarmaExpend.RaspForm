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
            this.components = new System.ComponentModel.Container();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.pbSeleccionado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.p1Precio = new System.Windows.Forms.Label();
            this.p2Precio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(66, 104);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(141, 91);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(362, 104);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(141, 91);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // pbSeleccionado
            // 
            this.pbSeleccionado.Location = new System.Drawing.Point(223, 287);
            this.pbSeleccionado.Name = "pbSeleccionado";
            this.pbSeleccionado.Size = new System.Drawing.Size(219, 134);
            this.pbSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSeleccionado.TabIndex = 2;
            this.pbSeleccionado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionado";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnComprar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(469, 333);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(146, 41);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // p1Precio
            // 
            this.p1Precio.AutoSize = true;
            this.p1Precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Precio.Location = new System.Drawing.Point(87, 212);
            this.p1Precio.Name = "p1Precio";
            this.p1Precio.Size = new System.Drawing.Size(100, 32);
            this.p1Precio.TabIndex = 5;
            this.p1Precio.Text = "Precio";
            // 
            // p2Precio
            // 
            this.p2Precio.AutoSize = true;
            this.p2Precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Precio.Location = new System.Drawing.Point(380, 212);
            this.p2Precio.Name = "p2Precio";
            this.p2Precio.Size = new System.Drawing.Size(100, 32);
            this.p2Precio.TabIndex = 6;
            this.p2Precio.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione un producto";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(407, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(221, 81);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(482, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "/dev/ttyACM0";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}