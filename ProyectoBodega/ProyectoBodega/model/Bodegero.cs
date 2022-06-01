using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBodega
{
	internal class Bodegero
	{
		private int bodegero_id;
		private String bodegero_run;
		private String bodegero_nombre;
		private String bodegero_password;

        public int Bodegero_id { get => bodegero_id; set => bodegero_id = value; }
        public string Bodegero_run { get => bodegero_run; set => bodegero_run = value; }
        public string Bodegero_nombre { get => bodegero_nombre; set => bodegero_nombre = value; }
        public string Bodegero_password { get => bodegero_password; set => bodegero_password = value; }

        public Bodegero()
        {
        }

        public Bodegero(int _bodegero_id, string _bodegero_run, string _bodegero_nombre, string _bodegero_password)
        {
            Bodegero_id = _bodegero_id;
            Bodegero_run = _bodegero_run;
            Bodegero_nombre = _bodegero_nombre;
            Bodegero_password = _bodegero_password;
        }
    }
}

