using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario
{
    public class Retiro
    {
        private int retiro_id;
        private int producto_id;

        public int Retiro_id { get => retiro_id; set => retiro_id = value; }
        public int Producto_id { get => producto_id; set => producto_id = value; }

        public Retiro()
        {
        }

        public Retiro(int _retiro_id, int _producto_id)
        {
            Retiro_id = _retiro_id;
            Producto_id = _producto_id;
        }
    }
}