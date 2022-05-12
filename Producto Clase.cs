using System;

public class Producto
{
	public Producto()

	private int producto_id = 1;
	private String bodegero_nombre = "Computador";
	private int producto_stock = 2;
	private bool producto_estado = false;

	public static void Main()
	{
		Producto Producto = new Producto();
		{
			Console.WriteLine("id:" + Producto.producto_id);
			Console.WriteLine("stock:" + Producto.producto_run);
			Console.WriteLine("nombre:" + Producto.producto_nombre);
			Console.WriteLine("estado:" + Producto.producto_estado);
		}
	}
}



