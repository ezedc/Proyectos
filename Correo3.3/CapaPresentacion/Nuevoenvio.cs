using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;


namespace CapaPresentacion
{     
    public partial class Nuevoenvio : Form
    {
        CD_envios objEnvios = new CD_envios();
        CD_envios objEmis = new CD_envios();
        CD_envios objRecep = new CD_envios();
        CD_envios objBol = new CD_envios();
        CN_envios objCN = new CN_envios();
        Envios mienvio = new Envios();
        Emisor miemi = new Emisor();
        Receptor mirecep = new Receptor();
        
        public Nuevoenvio()
        {
            InitializeComponent();
        }

        private void Nuevoenvio_Load(object sender, EventArgs e)
        {

            ListarDistancias();
            ListarPesos();
            ListarTipoEnvios();

          
        }


        private void ListarDistancias()
        {
            CD_envios objEnv = new CD_envios();
            cboxDis.DataSource = objEnv.ListarDistancias();
            cboxDis.DisplayMember = "distancia";
            cboxDis.ValueMember = "iddistancia";
                                  
        }
        
        private void ListarPesos()
        {
            CD_envios objPeso = new CD_envios();
            cboxPeso.DataSource = objPeso.ListarPesos();
            cboxPeso.DisplayMember = "peso";
            cboxPeso.ValueMember = "idpeso";
        }

        private void ListarTipoEnvios()
        {
            CD_envios objTipo = new CD_envios();
            cboxEnvio.DataSource = objTipo.ListarTipoEnvios();
            cboxEnvio.DisplayMember = "tipoenv";
            cboxEnvio.ValueMember = "idtipo";
        }

        private void btncostos_Click(object sender, EventArgs e)
        {
                        
            float total = 0;
            //distancia
            int indicedis = cboxDis.SelectedIndex;
         
            float costodis = 0;
            if (indicedis == 0)
            { costodis = 150;
                total = costodis;
                txtCostoTotal.Text = total.ToString();
            }

            if (indicedis== 1)
            {
                costodis = 200;
                txtCostoTotal.Text = total.ToString();

            }
            if (indicedis== 2)
            { costodis = 500;
              txtCostoTotal.Text = total.ToString();
            }
            //PESO
            int indicepeso = cboxPeso.SelectedIndex;
            float peso = 0;
            if (indicepeso == 0)
            {
                peso = costodis + 100;
                total = peso;
                txtCostoTotal.Text = total.ToString();
            }

            if (indicepeso == 1)
            {
                peso = costodis + 150;
                total = peso;
                txtCostoTotal.Text = total.ToString();
            }

            //tipoenvio

            int indicetipo = cboxEnvio.SelectedIndex;
            if (indicetipo == 0)
            {
                total = peso + 0;
                txtCostoTotal.Text = total.ToString();
            }

            if (indicetipo == 1)
            {
                total = peso+ 100;
                txtCostoTotal.Text = total.ToString();
            }


        }

        private void cboxDis_TextChanged(object sender, EventArgs e)
        { 
            
        }
        
        private void cboxDis_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        { 
            

            miemi.Nom = txtNomemi.Text;
            miemi.Ape = txtApeEmi.Text;
            miemi.Dniclien =Convert.ToInt32( txtDniEmi.Text);
            miemi.Tel = Convert.ToInt32(txtTelEmi.Text);
            miemi.Local = txtLocEmi.Text;
            miemi.Domic = txtDirEmi.Text;
            miemi.Cp = Convert.ToInt32(txtCpEmi.Text);

            mirecep.Nom = txtNomRecep.Text;
            mirecep.Ape = txtApeRec.Text;
            mirecep.Dniclien = Convert.ToInt32(txtDniRec.Text);
            mirecep.Tel = Convert.ToInt32(txtTelRec.Text);
            mirecep.Local = txtLocRec.Text;
            mirecep.Domic = txtDirRec.Text;
            mirecep.Cp =Convert.ToInt32( txtCpRec.Text);

            mienvio.Costo =Convert.ToDouble(txtCostoTotal.Text);
            mienvio.Dis = Convert.ToInt32(cboxDis.SelectedValue);
            mienvio.Pesopaq =Convert.ToInt32(cboxPeso.SelectedValue);
            mienvio.Tip =Convert.ToInt32(cboxEnvio.SelectedValue);

            /*DateTime actual = dateTimePicker.Value.Date;

            mienvio.Fecha = actual;*/
               

          

            try
            {
                objEnvios.insertarenvio(mienvio.Costo,mienvio.Dis,mienvio.Pesopaq,mienvio.Tip);
                             
                objEmis.insertaremisor(miemi.Nom ,miemi.Ape, miemi.Dniclien, miemi.Domic, miemi.Local,  miemi.Cp, miemi.Tel);

                objRecep.insertarreceptor(mirecep.Nom, mirecep.Ape, mirecep.Dniclien, mirecep.Domic, mirecep.Local, mirecep.Cp, mirecep.Tel);

                objBol.boleta(mirecep.Nom, mirecep.Nom, mirecep.Ape, miemi.Ape, Convert.ToString(mirecep.Dniclien), mirecep.Local, mirecep.Domic, Convert.ToString(cboxPeso.Text), Convert.ToString(cboxEnvio.Text), Convert.ToString(cboxDis.Text), Convert.ToString(mienvio.Costo));
                MessageBox.Show("Se ha registrado el envio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar por:"+ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
