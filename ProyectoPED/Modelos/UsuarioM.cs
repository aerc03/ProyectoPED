using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Modelos
{
    class UsuarioM
    {
        public int Codigo { get; set; }
        public string Username { get; set; }
        public string Contra { get; set; }
        public bool Nivel { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresApellidos { get; set; }
        public string Correo { get; set; }
    }
}
