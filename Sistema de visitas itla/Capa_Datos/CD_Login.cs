using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Configuration;

namespace Capa_Datos
{
    public class CD_Login : CD_Conexion
    {
        public void Guardar_CD()
        {
            SqlCommand cmd = new SqlCommand("sp_guardar_usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@_user", CE_Login.User);
            cmd.Parameters.AddWithValue("@_pass", CE_Login.Pass);
            cmd.Parameters.AddWithValue("@nombre", CE_Login.Nombre1);
            cmd.Parameters.AddWithValue("@apellido", CE_Login.Apellido1);
            cmd.Parameters.AddWithValue("@cargo", CE_Login.Cargo1);
            cmd.Parameters.AddWithValue("@fecha", CE_Login.Fecha1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void Editar_CD()
        {
            SqlCommand cmd = new SqlCommand("sp_editar_usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@id", CE_Login.ID1);
            cmd.Parameters.AddWithValue("@_user", CE_Login.User);
            cmd.Parameters.AddWithValue("@_pass", CE_Login.Pass);
            cmd.Parameters.AddWithValue("@nombre", CE_Login.Nombre1);
            cmd.Parameters.AddWithValue("@apellido", CE_Login.Apellido1);
            cmd.Parameters.AddWithValue("@cargo", CE_Login.Cargo1);
            cmd.Parameters.AddWithValue("@fecha", CE_Login.Fecha1);

            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void Borrar_CD()
        {
            SqlCommand cmd = new SqlCommand("sp_borrar_usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;
            cxn.Open();

            cmd.Parameters.AddWithValue("@id", CE_Login.ID1);

            cmd.ExecuteNonQuery();
            cxn.Close();
        }
        public DataTable Buscar_CD()
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_usuarios", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@id", CE_Login.ID1);
            cmd.Parameters.AddWithValue("@_user", CE_Login.User);

            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cxn.Close();
            return tabla;

        }
        public DataTable Mostrar_CD()
        {
            SqlCommand cmd = new SqlCommand("select * from vw_usuarios", cxn);
            cxn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cxn.Close();
            return dataTable;
        }
        public DataTable Login_CD()
        {
            SqlCommand Command = new SqlCommand("SP_Loging", cxn);
            Command.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            Command.Parameters.AddWithValue("@_user", CE_Login.User);
            Command.Parameters.AddWithValue("@_pass", CE_Login.Pass);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cxn.Close();
            return dataTable;

        }
    }
}
