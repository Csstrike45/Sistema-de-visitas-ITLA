using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        private readonly string conexion;

        protected SqlConnection cxn = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        public CD_Conexion()
        {
            conexion = (ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        }
        protected SqlConnection GetCnx()
        {
            return new SqlConnection(conexion);
        }
    }
}
