using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using Capa_Datos;
using System.Configuration;

namespace Capa_Negocio
{
    public class CN_Login 
    {
        CD_Login ObjDatos = new CD_Login();

        public void Guardando_CN()
        {
            ObjDatos.Guardar_CD();
        }

        public DataTable Buscando_CN()
        {
            return ObjDatos.Buscar_CD();
        }
        public DataTable Mostrando_CN()
        {
            return ObjDatos.Mostrar_CD();
        }

        public void Editando_CN()
        {
            ObjDatos.Editar_CD();
        }

        public void Borrando_CN()
        {
            ObjDatos.Borrar_CD();
        }
        public DataTable Login_CN()
        {
            return ObjDatos.Login_CD();
        }

        public void DatosUser_CN()
        {

            if (CE_Login.Cargo1 == CE_Cargos.Administrador)
            {
            }
            if (CE_Login.Cargo1 == CE_Cargos.General)
            {

            }

        }
    }
}
