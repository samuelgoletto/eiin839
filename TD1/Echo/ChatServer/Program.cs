using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;


namespace Echo
{
    class EchoServer
    {
        [Obsolete]
        static void Main(string[] args)
        {

            Console.CancelKeyPress += delegate
            {
                System.Environment.Exit(0);
            };

            TcpListener ServerSocket = new TcpListener(5000);
            ServerSocket.Start();

            Console.WriteLine("Server started.");
            while (true)
            {
                TcpClient clientSocket = ServerSocket.AcceptTcpClient();
                handleClient client = new handleClient();
                client.startClient(clientSocket);
            }


        }
    }

    public class handleClient
    {
        TcpClient clientSocket;
        public void startClient(TcpClient inClientSocket)
        {
            this.clientSocket = inClientSocket;
            Thread ctThread = new Thread(Echo);
            ctThread.Start();
        }



        private void Echo()
        {
            NetworkStream stream = clientSocket.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);

            while (true)
            {
                string str = reader.ReadString();
                string[] subs = str.Split(' ');
                if (subs[0].Equals("GET"))
                {
                    var url = "http://" + subs[1];

                    var request = WebRequest.Create(url);
                    request.Method = "GET";

                    using var webResponse = request.GetResponse();
                    using var webStream = webResponse.GetResponseStream();

                    using var myReader = new StreamReader(webStream);
                    var data = myReader.ReadToEnd();

                    Console.WriteLine(data);
                } else
                {
                    Console.WriteLine(str);
                }
            }
        }



    }

}