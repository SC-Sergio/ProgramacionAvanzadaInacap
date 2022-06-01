using ProyectoBodega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProyectoBodega.Modelo
{
    public class Program 
    {
            static void Main (String[] args)
        {

            Console.WriteLine("----------Retiro-------------");
            Console.WriteLine("");
            Retiro retiro1 = new Retiro(); //Clase Retiro
            retiro1.Producto_id= 1;
            retiro1.Retiro_id = 1;
            Thread.Sleep(800); //Thread

            Console.WriteLine("Producto id:" + retiro1.Producto_id);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Retiro id:" + retiro1.Retiro_id);
            Thread.Sleep(800); //Thread


            Console.WriteLine("");

            Console.WriteLine("----------Administrador-------------");
            Console.WriteLine("");

            Administrador admin = new Administrador(); //Clase Administrador

            admin.Administrador_run = "19872413-0";
            admin.Administrador_password = "Inacap123";
            admin.Administrador_nombre = "Sergio";

            Console.WriteLine("RUN:" + admin.Administrador_run);
            Thread.Sleep(800); //Thread


            Console.WriteLine("Nombre:" + admin.Administrador_nombre);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Password:" + admin.Administrador_password);
            Thread.Sleep(800); //Thread

            Console.WriteLine("");
            Console.WriteLine("----------Bodega-------------");
            Console.WriteLine("");
            Bodega Bodega = new Bodega();

            Bodega.Bodeguero_id= 1;
            Bodega.Bodeguero_run = "11111111-1";

            Console.WriteLine("RUN:" + Bodega.Bodeguero_run);
            Thread.Sleep(800); //Thread


            Console.WriteLine("ID:" + Bodega.Bodeguero_id);
            Thread.Sleep(800); //Thread

            Console.WriteLine("");
            Console.WriteLine("----------Bodeguero-------------");
            Console.WriteLine("");
            Bodegero bodegero1 = new Bodegero();

            bodegero1.Bodegero_id= 1;
            bodegero1.Bodegero_run = "11111111-1";
            bodegero1.Bodegero_nombre = "Cristian";
            bodegero1.Bodegero_password = "Hola123";

            Console.WriteLine("RUN:" + bodegero1.Bodegero_run);
            Thread.Sleep(800); //Thread


            Console.WriteLine("ID:" + bodegero1.Bodegero_id);
            Thread.Sleep(800); //Thread

            Console.WriteLine("NOMBRE:" + bodegero1.Bodegero_nombre);
            Thread.Sleep(800); //Thread


            Console.WriteLine("PASSWORD" + bodegero1.Bodegero_password);
            Thread.Sleep(800); //Thread

            Console.WriteLine("----------Producto-------------");
            Console.WriteLine("");
            Producto producto = new Producto();

            producto.Producto_id = 1;
            producto.Producto_nombre = " Samsung Galaxy S20 ";
            producto.Producto_stock = 2;
            producto.Producto_estado = true;

            Console.WriteLine("ID:" + producto.Producto_id);
            Thread.Sleep(800); //Thread


            Console.WriteLine("NOMBRE:" + producto.Producto_nombre);
            Thread.Sleep(800); //Thread

            Console.WriteLine("STOCK:" + producto.Producto_stock);
            Thread.Sleep(800); //Thread


            Console.WriteLine("ESTADO" + producto.Producto_estado);
            Thread.Sleep(800); //Thread

            Console.WriteLine("----------Estado-------------");
            Console.WriteLine("");
            Estado estado = new Estado(); //Clase Estado
            estado.Producto_id = 1;
            Thread.Sleep(800); //Thread

            Console.WriteLine("Estado id:" + estado.Producto_id);
            Thread.Sleep(800); //Thread




            ServidorSocket servidorSocket = new ServidorSocket();

            servidorSocket.Conectar();

            Console.ReadKey();


            { 
           

            }
            
                
            }
    }
}
