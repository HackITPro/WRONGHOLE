using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Wronghole
{
    class Server_bak
    {
        public IPAddress Ip { get; set; }
        public int Port { get; set; }
        public string Proto { get; set; }
        public IPEndPoint localEndpoint { get; set; }
        public Socket listen { get; set; }
        public bool cliConnect { get; set; }
        public bool isStopping { get; set; }
        public List<Socket> clients = new List<Socket>();

        public Server_bak(string ip, string port, string proto)
        {
            Ip = IPAddress.Parse(ip);
            Port = Int32.Parse(port);
            Proto = proto;
            //Debug line.  Go To Project -> Properties -> Application and set the Console Application to see Console output.  Change back to Windows Application before production.
            Console.WriteLine(Proto);
            localEndpoint = new IPEndPoint(Ip, Port);
            if (Proto == "TCP")
            {
                listen = new Socket(Ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            }
            if (Proto == "UDP")
            {
                listen = new Socket(Ip.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            }
        }

        public void StartServer()
        {
            if (Proto == "TCP")
            {


                listen.Bind(localEndpoint);
                listen.Listen(200);
                //Testing server functionality
                while (true)
                {
                    if (clients.Count == 0)
                    {
                        cliConnect = false;
                    }
                    else
                    {
                        cliConnect = true;
                    }
                    //Debug
                    Console.WriteLine("Waiting for connection....");
                    
                    try
                    {
                        Socket clientSocket = listen.Accept();
                        Console.WriteLine("Client connection from " + clientSocket.RemoteEndPoint);
                        Task.Factory.StartNew(() => HandleClient(clientSocket));
                    }
                    catch (Exception)
                    {
                        if (isStopping)
                        {
                            break;
                        }
                    }
                    
                    //Debug                  

                }
            }

            else if (Proto == "UDP")
            {

                int receivedDataLen;
                byte[] data = new byte[1024];
                listen.Bind(localEndpoint);

                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint Remote = (EndPoint)(sender);

                while (true)
                {
                    try
                    {
                        //Code here will be for testing 
                        data = new byte[1024];
                        receivedDataLen = listen.ReceiveFrom(data, ref Remote);
                        Console.WriteLine(Encoding.Unicode.GetString(data, 0, receivedDataLen));
                        listen.SendTo(data, receivedDataLen, SocketFlags.None, Remote);
                    }
                    catch (Exception)
                    {
                        if (isStopping)
                        {
                            break;
                        }                        
                    }

                }

            }

        }

        private void HandleClient(Socket clientSocket)
        {
            clients.Add(clientSocket);
            byte[] bytes = new Byte[1024];
            string data = null;
            //while (true)
            //{
                try
                {
                    // Debug test comms for server.  Write communication code here.
                    int numByte = clientSocket.Receive(bytes);
                    //data += Encoding.Unicode.GetString(bytes, 0, numByte);
                    data += Encoding.ASCII.GetString(bytes, 0, numByte);
                    Console.WriteLine("Text received -> {0} ", data);
                    //byte[] message = Encoding.Unicode.GetBytes("Test Server");
                    byte[] message = Encoding.ASCII.GetBytes("Test Server");
                    clientSocket.Send(message);
                }
                catch(Exception e)
                {
                    //Debug
                    Console.WriteLine(e.ToString());
                    //Check to see if client is still connected after exception has been thrown.
                    if (!clientSocket.Connected)
                    {
                        //if client is not connected, remove client from clients list, shutdown the socket, and close the socket.
                        clients.Remove(clientSocket);
                        clientSocket.Shutdown(SocketShutdown.Both);
                        clientSocket.Close();
                    }
                    //Break out of client handler.
                    //break;
                }
            //}
        }
        public void ShutdownServer()
        {
            try
            {
                listen.Dispose();
                isStopping = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
