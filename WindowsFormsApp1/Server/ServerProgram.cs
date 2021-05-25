using MySql.Data.MySqlClient; //для работы клиента с сервером
//using Npgsql;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.Threading;

namespace Server
{
    class ServerProgram
    {


        static void Main(string[] args)
        {
            serverDB db = new serverDB();
            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            TcpListener serverSocket = new TcpListener(8888);            
            //int requestCount = 0;            
            TcpClient clientSocket = default(TcpClient);
            serverSocket.Start();
            //Console.WriteLine(" >> Server Started");           
            clientSocket = serverSocket.AcceptTcpClient();            
            //Console.WriteLine(" >> Accept connection from client");            
            //requestCount = 0;


            while ((true))
            {
                try
                {
                    //requestCount = requestCount + 1;
                    
                    NetworkStream networkStream = clientSocket.GetStream();
                   
                    byte[] bytesFrom = new byte[10025];
                    
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    
                    Console.WriteLine(" >> Data from client - " + dataFromClient);
                    
                    string serverResponse = "Last Message from client" + dataFromClient;
                    
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


            // получаем адреса для запуска сокета
            //IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), localPort);

            //// создаем сокет
            //Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //try
            //{
            //    // связываем сокет с локальной точкой, по которой будем принимать данные
            //    listenSocket.Bind(ipPoint);

            //    // начинаем прослушивание
            //    listenSocket.Listen(10);

            //    Console.WriteLine("Сервер запущен. Ожидание подключений...");

            //    while (true)
            //    {
            //        Socket handler = listenSocket.Accept();

            //        // получаем сообщение
            //        StringBuilder builder = new StringBuilder();
            //        int bytes = 0; // количество полученных байтов
            //        byte[] data = new byte[256]; // буфер для получаемых данных

            //        do
            //        {
            //            bytes = handler.Receive(data);
            //            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            //        }
            //        while (handler.Available > 0);

            //        Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

            //        // отправляем ответ
            //        string message = "ваше сообщение доставлено";
            //        data = Encoding.Unicode.GetBytes(message);
            //        handler.Send(data);
            //        // закрываем сокет
            //        handler.Shutdown(SocketShutdown.Both);
            //        handler.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



        }
    }
}
