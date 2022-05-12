using System;

public class Bodeguero
{
	public Bodeguero()

	private int bodegero_id = 1;
	private String bodegero_run = "1111111-1";
	private String bodegero_nombre = "Sergio";
	private String bodegero_password = "Inacap1234";
	public static void Main()
	{
		Bodegero bodegero = new Bodegero();
		{
			Console.WriteLine("id:" + bodegero.bodegero_id);
			Console.WriteLine("run:" + bodegero.bodegero_run);
			Console.WriteLine("nombre:" + bodegero.bodegero_nombre);
			Console.WriteLine("password:" + bodegero.bodegero_password);
		}
	}
}
