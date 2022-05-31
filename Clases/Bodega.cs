using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBodega
{
    internal class Bodega
    {

		private int bodeguero_id;
		private String bodeguero_run;

        public int Bodeguero_id { get => bodeguero_id; set => bodeguero_id = value; }
        public string Bodeguero_run { get => bodeguero_run; set => bodeguero_run = value; }

        public Bodega()
        {
        }

        public Bodega(int _bodeguero_id, string _bodeguero_run)
        {
            this.bodeguero_id = _bodeguero_id;
            this.bodeguero_run = _bodeguero_run;
        }
    }
}
