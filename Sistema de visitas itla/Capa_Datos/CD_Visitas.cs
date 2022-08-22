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
    public class CD_Visitas : CD_Conexion
    {
        public void Guardar_CD(CE_Visitas cE_Visitas)
        {
            SqlCommand cmd = new SqlCommand("sp_guardar_visitantes", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@nombre", cE_Visitas.Nombre1);
            cmd.Parameters.AddWithValue("@apellido", cE_Visitas.Apellido1);
            cmd.Parameters.AddWithValue("@edificio", cE_Visitas.Edificio1);
            cmd.Parameters.AddWithValue("@aula", cE_Visitas.Aula1);
            cmd.Parameters.AddWithValue("@telefono", cE_Visitas.Telefono1);
            cmd.Parameters.AddWithValue("@tipo_visita", cE_Visitas.TipoVisitante1);
            cmd.Parameters.AddWithValue("@hora_entrada", cE_Visitas.FechaEntrada1);
            cmd.Parameters.AddWithValue("@hora_salida", cE_Visitas.FechaSalida1);
            cmd.Parameters.AddWithValue("@carrera", cE_Visitas.Carrera1);
            cmd.Parameters.AddWithValue("@correo", cE_Visitas.Correo1);
            cmd.Parameters.AddWithValue("@matricula", cE_Visitas.Matricula1);
            cmd.Parameters.AddWithValue("@motivo_visita", cE_Visitas.MotivoVisita1);
            cmd.Parameters.AddWithValue("@foto", cE_Visitas.Foto1);


            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void Editar_CD(CE_Visitas cE_Visitas)
        {
            SqlCommand cmd = new SqlCommand("sp_editar_visitantes", cxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cxn.Open();
            cmd.Parameters.AddWithValue("@id", cE_Visitas.Id1);
            cmd.Parameters.AddWithValue("@nombre", cE_Visitas.Nombre1);
            cmd.Parameters.AddWithValue("@apellido", cE_Visitas.Apellido1);
            cmd.Parameters.AddWithValue("@edificio", cE_Visitas.Edificio1);
            cmd.Parameters.AddWithValue("@aula", cE_Visitas.Aula1);
            cmd.Parameters.AddWithValue("@telefono", cE_Visitas.Telefono1);
            cmd.Parameters.AddWithValue("@tipo_visita", cE_Visitas.TipoVisitante1);
            cmd.Parameters.AddWithValue("@hora_entrada", cE_Visitas.FechaEntrada1);
            cmd.Parameters.AddWithValue("@hora_salida", cE_Visitas.FechaSalida1);
            cmd.Parameters.AddWithValue("@carrera", cE_Visitas.Carrera1);
            cmd.Parameters.AddWithValue("@correo", cE_Visitas.Correo1);
            cmd.Parameters.AddWithValue("@matricula", cE_Visitas.Matricula1);
            cmd.Parameters.AddWithValue("@motivo_visita", cE_Visitas.MotivoVisita1);
            cmd.Parameters.AddWithValue("@foto", cE_Visitas.Foto1);
            cmd.ExecuteNonQuery();

            cxn.Close();
        }
        public void Borrar_CD(CE_Visitas cE_Visitas)
        {
            SqlCommand cmd = new SqlCommand("sp_borrar_visitantes", cxn);
            cmd.CommandType = CommandType.StoredProcedure;
            cxn.Open();

            cmd.Parameters.AddWithValue("@id", cE_Visitas.Id1);

            cmd.ExecuteNonQuery();
            cxn.Close();
        }
        public List<CE_Visitas> BUSCAR_D(string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("sp_buscar_visitantes", cxn);
            cmd.CommandType = CommandType.StoredProcedure;
            cxn.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leer = cmd.ExecuteReader();

            List<CE_Visitas> Listar = new List<CE_Visitas>();
            while (leer.Read())
            {
                Listar.Add(new CE_Visitas
                {
                    Nombre1 = leer.GetString(2),
                    Apellido1 = leer.GetString(3),
                    Edificio1 = leer.GetString(4),
                    Aula1 = leer.GetString(5),
                    Telefono1 = leer.GetString(6),
                    TipoVisitante1 = leer.GetString(7),
                    FechaEntrada1 = leer.GetDateTime(8),
                    FechaSalida1 = leer.GetDateTime(9),
                    Carrera1 = leer.GetString(10),
                    Correo1 = leer.GetString(11),
                    Matricula1 = leer.GetString(12),
                    MotivoVisita1 = leer.GetString(13)
                });
            }

            cxn.Close();
            leer.Close();
            return Listar;
        }
        public DataTable Mostrar_CD()
        {
            cxn.Open();
            SqlCommand cmd = new SqlCommand("select * from vw_visitante", cxn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cxn.Close();
            return dataTable;
        }
    }
}
