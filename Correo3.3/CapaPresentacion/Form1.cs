using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void AbrirformHija (object formhija)
        {
            if(this.panelContenedor.Controls.Count > 0)
            
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
                       
       
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Allenvios());
        }

        private void btnNuevoEnvio_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Nuevoenvio());
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblreloj.Text = DateTime.Now.ToString();
        }

        private void lblreloj_Click(object sender, EventArgs e)
        {

        }
    }
}
