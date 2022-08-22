using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Visitas
    {
        CD_Visitas ObjDatos = new CD_Visitas();

        public void Guardando_CN(CE_Visitas cE_Visitas)
        {
            ObjDatos.Guardar_CD(cE_Visitas);
        }

        public List<CE_Visitas> Buscando_CN(string buscar)
        {
            return ObjDatos.BUSCAR_D(buscar);
        }
        public DataTable Mostrando_CN()
        {
            return ObjDatos.Mostrar_CD();
        }

        public void Editando_CN(CE_Visitas cE_Visitas)
        {
            ObjDatos.Editar_CD(cE_Visitas);
        }

        public void Borrando_CN(CE_Visitas cE_Visitas)
        {
            ObjDatos.Borrar_CD(cE_Visitas);
        }
    }
}
