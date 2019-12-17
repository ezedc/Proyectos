using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace CapaDatos
{
   public class CD_envios
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer; //leer filas de la tabla
        DataTable tabla= new DataTable(); //almacenar filas de la consulta
        SqlCommand comando = new SqlCommand();//ejecutar instrucciones transact sql

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select idenvio as NroEnvio,nomb_emis+apell_emis as Emisor,nomb_recep+apell_recep as Receptor,loc_recep as LocalidadDestino,domicilio_recep as Destino,cp_recep as CpDestino,costo as Costo,distancia as Diskm,peso as Peso_paquete,tipoenv as Tipo_Envio,fecha as Fecha from envios inner join emisor on envios.idenvio = emisor.idsolicitud INNER JOIN receptor on envios.idenvio = receptor.idsolici_recep inner join dis on envios.iddistancia = dis.iddistancia inner join pes on envios.idpeso = pes.idpeso inner join tipoenvio on envios.idtipo = tipoenvio.idtipo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
           
            conexion.CerrarConexion();
            return tabla;
           }

        public DataTable ListarDistancias()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from dis Order by iddistancia";
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }


        public DataTable ListarPesos()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from pes Order by idpeso";
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarTipoEnvios()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from tipoenvio Order by idtipo";
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }


        public void insertarenvio( double costo, int distancia,int peso,int tipo)
        {
            DateTime fec = DateTime.Now;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO envios (costo,iddistancia,idpeso,idtipo,fecha) VALUES ("+costo+","+distancia+","+peso+","+tipo+",'"+fec.ToString("G") + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void insertaremisor(string nombre, string apellido, int dni, string dir, string loc, int cp,int tel)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO  emisor (nomb_emis,apell_emis,dni_emis,domicilio_emis,loc_emis,cp_emis,telefono) values('"+nombre+"','"+apellido+"',"+dni+",'"+dir+"','"+loc+"',"+cp+","+tel+")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void insertarreceptor(string nombre, string apellido, int dni, string dir, string loc, int cp, int tel)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO  receptor (nomb_recep,apell_recep,dni_recep,domicilio_recep,loc_recep,cp_recep,telefono) values('" + nombre + "','" + apellido + "'," + dni + ",'" + dir + "','" + loc + "'," + cp + "," + tel + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();



        }
        public void boleta(string nom,string nombrec,string  aperec, string ape, string dni, string loc, string direc, string peso, string tipo, string dist, string precio)
        {

            DateTime fec = DateTime.Now;
            string fecha = Convert.ToString(fec);
           
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\ezequ\Desktop\Comprobante.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Boleta");
            doc.AddCreator("Ezequiel del Castillo");

            // Abrimos el archivo
            doc.Open();

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Comprobante de envio"));
            doc.Add(Chunk.NEWLINE);

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla que contendrá el nombre, apellido y país 
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(12);
            tblPrueba.WidthPercentage = 90;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre Emisor", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido Emisor", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clnomrecep = new PdfPCell(new Phrase("Nombre Receptor ", _standardFont));
            clnomrecep.BorderWidth = 0;
            clnomrecep.BorderWidthBottom = 0.75f;

            PdfPCell clAperec = new PdfPCell(new Phrase("Apellido Receptor ", _standardFont));
            clAperec.BorderWidth = 0;
            clAperec.BorderWidthBottom = 0.75f;

            PdfPCell cldnire = new PdfPCell(new Phrase("Dni Receptor", _standardFont));
            cldnire.BorderWidth = 0;
            cldnire.BorderWidthBottom = 0.75f;

            PdfPCell cllocal = new PdfPCell(new Phrase("Localidad Destino ", _standardFont));
            cllocal.BorderWidth = 0;
            cllocal.BorderWidthBottom = 0.75f;

            PdfPCell cldirrec = new PdfPCell(new Phrase("Direccion Destino", _standardFont));
            cldirrec.BorderWidth = 0;
            cldirrec.BorderWidthBottom = 0.75f;

          

            PdfPCell clpeso = new PdfPCell(new Phrase("Peso Paquete", _standardFont));
            clpeso.BorderWidth = 0;
            clpeso.BorderWidthBottom = 0.75f;

            PdfPCell cltipo = new PdfPCell(new Phrase("Tipo envio ", _standardFont));
            cltipo.BorderWidth = 0;
            cltipo.BorderWidthBottom = 0.75f;

            PdfPCell cldis = new PdfPCell(new Phrase("Distancia ", _standardFont));
            cldis.BorderWidth = 0;
            cldis.BorderWidthBottom = 0.75f;

            PdfPCell clprec = new PdfPCell(new Phrase("Costo", _standardFont));
            clprec.BorderWidth = 0;
            clprec.BorderWidthBottom = 0.75f;

            PdfPCell clfec = new PdfPCell(new Phrase("Fecha Emision ", _standardFont));
            clfec.BorderWidth = 0;
            clfec.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clnomrecep);
            tblPrueba.AddCell(clAperec);
            tblPrueba.AddCell(cldnire);
            tblPrueba.AddCell(cllocal);
            tblPrueba.AddCell(cldirrec);
            tblPrueba.AddCell(clpeso);
            tblPrueba.AddCell(cltipo);
            tblPrueba.AddCell(cldis);
            tblPrueba.AddCell(clprec);
            tblPrueba.AddCell(clfec);



            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase(nom, _standardFont));
            clNombre.BorderWidth = 0;

            clApellido = new PdfPCell(new Phrase(ape, _standardFont));
            clApellido.BorderWidth = 0;

            clnomrecep = new PdfPCell(new Phrase(nombrec, _standardFont));
            clnomrecep.BorderWidth = 0;

            clAperec = new PdfPCell(new Phrase(aperec, _standardFont));
            clAperec.BorderWidth = 0;

            cldnire = new PdfPCell(new Phrase(dni, _standardFont));
            cldnire.BorderWidth = 0;

            cllocal = new PdfPCell(new Phrase(loc, _standardFont));
            cllocal.BorderWidth = 0;

            cldirrec = new PdfPCell(new Phrase(direc, _standardFont));
            cldirrec.BorderWidth = 0;

            clpeso = new PdfPCell(new Phrase(peso, _standardFont));
            clpeso.BorderWidth = 0;

            cltipo = new PdfPCell(new Phrase(tipo, _standardFont));
            cltipo.BorderWidth = 0;

            cldis = new PdfPCell(new Phrase(dist, _standardFont));
            cldis.BorderWidth = 0;

            

            clprec = new PdfPCell(new Phrase(precio, _standardFont));
            cldis.BorderWidth = 0;

            clfec= new PdfPCell(new Phrase(fecha, _standardFont));
            clfec.BorderWidth = 0;



            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clnomrecep);
            tblPrueba.AddCell(clAperec);
            tblPrueba.AddCell(cldnire);
            tblPrueba.AddCell(cllocal);
            tblPrueba.AddCell(cldirrec);
            tblPrueba.AddCell(clpeso);
            tblPrueba.AddCell(cltipo);
            tblPrueba.AddCell(cldis);
            tblPrueba.AddCell(clprec);
            tblPrueba.AddCell(clfec);



            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            //MessageBox.Show("¡PDF creado!");






        }

        }
}
