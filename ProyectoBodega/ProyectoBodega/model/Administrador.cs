using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBodega
{
    internal class Administrador
    {
        private String administrador_run;
        private String administrador_nombre;
        private String administrador_password;

        public string Administrador_run { get => administrador_run; set => administrador_run = value; }
        public string Administrador_nombre { get => administrador_nombre; set => administrador_nombre = value; }
        public string Administrador_password { get => administrador_password; set => administrador_password = value; }

        public Administrador()
        {
        }

        public Administrador(string _administrador_run, string _administrador_nombre, string _administrador_password)
        {
            Administrador_run = _administrador_run;
            Administrador_nombre = _administrador_nombre;
            Administrador_password = _administrador_password;
        }
    }
	
}
