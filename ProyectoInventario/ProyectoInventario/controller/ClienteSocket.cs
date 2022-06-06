using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ProyectoInventario.controller
{
    internal class ClienteSocket
    {
        public void Conectar()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 433);



            socket.Connect(direccion);


            Console.WriteLine("Conectado de manera Exitosa\n");
            Console.WriteLine("Ingrese la informacion para poder enviarla\n\n");



            string info = Console.ReadLine();



            byte[] infoEnviar = Encoding.Default.GetBytes(info);



            socket.Send(infoEnviar, 0, infoEnviar.Length, 0);
            socket.Close();



            Console.WriteLine("Presione cualquier tecla para finalizar...");



            Console.ReadKey();


        }
    }
}

