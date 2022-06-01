using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBodega
{
    internal class Estado
    {
        private int producto_id;

        public int Producto_id { get => producto_id; set => producto_id = value; }

        public Estado()
        {
        }

        public Estado(int _producto_id)
        {
            Producto_id = _producto_id;
        }
        //public void Estado()
        }
    }

