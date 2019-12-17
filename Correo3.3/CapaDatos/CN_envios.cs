using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
   public  class CN_envios
    {
        private CD_envios objetocd = new CD_envios();

        public DataTable MostrarEnvios()
        {
            DataTable tabla = new DataTable();
            tabla = objetocd.Mostrar();
            return tabla;
        }

      

    }
}
