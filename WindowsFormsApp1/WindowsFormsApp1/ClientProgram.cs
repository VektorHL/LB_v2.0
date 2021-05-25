using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;
using Objects;

namespace Client
{
    static class ClientProgram
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MessageData md = new MessageData();
            //md.M_login = "123";
            //md.M_password = "123";

            //MessageClient client = new MessageClient(515);
            //client.StartListening();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationWindow());
        }
    }



    //public class MessageClient
    //{
    //    private int _port;
    //    private TcpClient _tcpClient;
    //    private BinaryFormatter _bFormatter;
    //    private Thread _listenThread;
    //    private bool _running;
    //    //private House house;
    //    private MessageData mD;

    //    public MessageClient(int port)
    //    {
    //        this._port = port;
    //        this._tcpClient = new TcpClient("127.0.0.1", port);
    //        this._bFormatter = new BinaryFormatter();
    //        this._running = false;
    //        //Stream stream = new Stream();
    //    }

    //    public void StartListening()
    //    {
    //        lock (this)
    //        {
    //            if (!_running)
    //            {
    //                this._running = true;
    //                this._listenThread = new Thread
    //                    (new ThreadStart(ListenForMessage));
    //                this._listenThread.Start();
    //            }
    //            else
    //            {
    //                this._running = true;
    //                this._listenThread = new Thread
    //                    (new ThreadStart(ListenForMessage));
    //                this._listenThread.Start();
    //            }
    //        }
    //    }

    //    private void ListenForMessage()
    //    {
    //        Console.WriteLine("Reading...");
    //        try
    //        {
    //            while (this._running)
    //            {
    //                this.mD = (MessageData)this._bFormatter.Deserialize(this._tcpClient.GetStream());
    //                //Console.WriteLine(this.house.Street);
    //                //Console.WriteLine(this.house.ZipCode);
    //                //Console.WriteLine(this.house.Number);
    //                //Console.WriteLine(this.house.Id);
    //                //Console.WriteLine(this.house.Town);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e);
    //            Console.ReadLine();
    //        }
    //    }
    //}
}
