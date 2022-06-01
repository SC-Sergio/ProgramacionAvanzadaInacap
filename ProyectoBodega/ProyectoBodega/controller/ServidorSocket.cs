using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ProyectoBodega
{
    internal class ServidorSocket
    {
       public void Conectar()
        {
        
            Socket socket = new Socket(AddressFamily.InterNetwork,  SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 431);
            socket.Bind(direccion);
            socket.Listen(5);
            
            Console.WriteLine("Escuchando..");
            
            
            Socket Escuchar = socket.Accept();

            Console.WriteLine("Conectado con Exito");

            byte[] ByRec = new byte[255];

            int a = Escuchar.Receive(ByRec,0 ,ByRec.Length, 0);

            Array.Resize(ref ByRec, a);

            Console.WriteLine("Cliente dice: "+ Encoding.Default.GetString(ByRec));

            socket.Close();

            Console.WriteLine("Presione cualquier tecla para terminar...");

            Console.ReadKey();
        }  

    }
}
