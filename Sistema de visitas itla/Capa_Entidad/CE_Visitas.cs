using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Visitas  
    {
        private int Id;
        private string Nombre;
        private string Apellido;
        private string Edificio;
        private string Aula;
        private string Telefono;
        private string TipoVisitante;
        private DateTime FechaEntrada;
        private DateTime FechaSalida;
        private string Carrera;
        private string Correo;
        private string Matricula;
        private string MotivoVisita;
        private Byte[] Foto;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Edificio1 { get => Edificio; set => Edificio = value; }
        public string Aula1 { get => Aula; set => Aula = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public  string TipoVisitante1 { get => TipoVisitante; set => TipoVisitante = value; }
        public  DateTime FechaEntrada1 { get => FechaEntrada; set => FechaEntrada = value; }
        public  DateTime FechaSalida1 { get => FechaSalida; set => FechaSalida = value; }
        public  string Carrera1 { get => Carrera; set => Carrera = value; }
        public  string Correo1 { get => Correo; set => Correo = value; }
        public  string Matricula1 { get => Matricula; set => Matricula = value; }
        public  string MotivoVisita1 { get => MotivoVisita; set => MotivoVisita = value; }
        public  byte[] Foto1 { get => Foto; set => Foto = value; }
    }
}
