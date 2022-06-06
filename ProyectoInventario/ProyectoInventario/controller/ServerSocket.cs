using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ProyectoInventario
{
    internal class ServerSocket
    {
        public void Conectar()
        {

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 433);
            socket.Bind(direccion);
            socket.Listen(5);

            Console.WriteLine("Recibiendo..");


            Socket Escuchar = socket.Accept();

            Console.WriteLine("Conectado de manera Exitosa");

            byte[] ByRec = new byte[255];

            int a = Escuchar.Receive(ByRec, 0, ByRec.Length, 0);

            Array.Resize(ref ByRec, a);

            Console.WriteLine("Cliente: " + Encoding.Default.GetString(ByRec));

            socket.Close();

            Console.WriteLine("Presione cualquier tecla para finalizar...");

            Console.ReadKey();
        }

    }
}
