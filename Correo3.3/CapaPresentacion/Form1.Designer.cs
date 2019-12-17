namespace CapaPresentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.lblreloj = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoEnvio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.MediumBlue;
            this.MenuVertical.Controls.Add(this.lblreloj);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnEnvios);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnNuevoEnvio);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 511);
            this.MenuVertical.TabIndex = 0;
            // 
            // lblreloj
            // 
            this.lblreloj.AutoSize = true;
            this.lblreloj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreloj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblreloj.Location = new System.Drawing.Point(22, 486);
            this.lblreloj.Name = "lblreloj";
            this.lblreloj.Size = new System.Drawing.Size(49, 16);
            this.lblreloj.TabIndex = 6;
            this.lblreloj.Text = "label1";
            this.lblreloj.Click += new System.EventHandler(this.lblreloj_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 31);
            this.panel2.TabIndex = 2;
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEnvios.FlatAppearance.BorderSize = 0;
            this.btnEnvios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnvios.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvios.Image")));
            this.btnEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvios.Location = new System.Drawing.Point(9, 189);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(188, 31);
            this.btnEnvios.TabIndex = 3;
            this.btnEnvios.Text = "           TODOS LOS ENVIOS";
            this.btnEnvios.UseVisualStyleBackColor = false;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnNuevoEnvio
            // 
            this.btnNuevoEnvio.BackColor = System.Drawing.Color.MediumBlue;
            this.btnNuevoEnvio.FlatAppearance.BorderSize = 0;
            this.btnNuevoEnvio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNuevoEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEnvio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEnvio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoEnvio.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEnvio.Image")));
            this.btnNuevoEnvio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEnvio.Location = new System.Drawing.Point(12, 139);
            this.btnNuevoEnvio.Name = "btnNuevoEnvio";
            this.btnNuevoEnvio.Size = new System.Drawing.Size(188, 31);
            this.btnNuevoEnvio.TabIndex = 1;
            this.btnNuevoEnvio.Text = "      NUEVO ENVIO";
            this.btnNuevoEnvio.UseVisualStyleBackColor = false;
            this.btnNuevoEnvio.Click += new System.EventHandler(this.btnNuevoEnvio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(784, 511);
            this.panelContenedor.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnNuevoEnvio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Label lblreloj;
        private System.Windows.Forms.Timer timer1;
    }
}

