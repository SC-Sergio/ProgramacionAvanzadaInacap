using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBodega
{
    internal class Producto
    {
		private int producto_id;
		private String bodegero_nombre;
		private int producto_stock;
		private bool producto_estado;

        public int Producto_id { get => producto_id; set => producto_id = value; }
        public string Bodegero_nombre { get => bodegero_nombre; set => bodegero_nombre = value; }
        public int Producto_stock { get => producto_stock; set => producto_stock = value; }
        public bool Producto_estado { get => producto_estado; set => producto_estado = value; }

        public Producto()
        {
        }

        public Producto(int _producto_id, string _bodegero_nombre, int _producto_stock, bool _producto_estado)
        {
            Producto_id = _producto_id;
            Bodegero_nombre = _bodegero_nombre;
            Producto_stock = _producto_stock;
            Producto_estado = _producto_estado;
        }
    }
}