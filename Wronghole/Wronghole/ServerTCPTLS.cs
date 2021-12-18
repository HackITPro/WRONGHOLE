using System;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Wronghole
{
    public sealed class SslTcpServer
    {
        static X509Certificate2 ServerCertificate { get; set; }
        public int Port { get; set; }
        public IPAddress Ip { get; set; }
        public TcpListener Listener { get; set; }
        public List<TcpClient> clients = new List<TcpClient>();
        public SslStream SslStream { get; set; }
        
        public SslTcpServer(string cert, string ip, string port)
        {
            Ip = IPAddress.Parse(ip);
            ServerCertificate = new X509Certificate2(cert, "deez");
            Port = Int32.Parse(port);

        }
        // The certificate parameter specifies the name of the file 
        // containing the machine certificate.
        public void RunServer()
        {
            Listener = new TcpListener(Ip, Port);
            Listener.Start();
            while (true)
            {
                Console.WriteLine("Waiting for a client to connect...");
                // Application blocks while waiting for an incoming connection.
                // Type CNTL-C to terminate the server.
                TcpClient client = Listener.AcceptTcpClient();
                clients.Add(client);
                Task.Factory.StartNew(() => ProcessClient(client));
            }
        }
        public static bool ValidateServerCertificate(
            object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        public void ProcessClient(TcpClient client)
        {
            // A client has connected. Create the 
            // SslStream using the client's network stream.
            SslStream = new SslStream(
                client.GetStream(), false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            // Authenticate the server but don't require the client to authenticate.
            try
            {
                SslStream.AuthenticateAsServer(ServerCertificate, clientCertificateRequired: true, enabledSslProtocols: SslProtocols.Tls12, checkCertificateRevocation: true);

                // Display the properties and settings for the authenticated stream.
                DisplaySecurityLevel(SslStream);
                DisplaySecurityServices(SslStream);
                DisplayCertificateInformation(SslStream);
                DisplayStreamProperties(SslStream);
                /*while (true)
                {
                    // Set timeouts for the read and write to 5 seconds.
                    sslStream.ReadTimeout = 5000;
                    sslStream.WriteTimeout = 5000;
                    // Read a message from the client.   
                    Console.WriteLine("Waiting for client message...");
                    string messageData = ReadMessage(sslStream);
                    Console.WriteLine("Received: {0}", messageData);

                    // Write a message to the client.
                    byte[] message = Encoding.UTF8.GetBytes("Hello from the server.<EOF>");
                    Console.WriteLine("Sending hello message.");
                    sslStream.Write(message);
                }*/
            }
            catch (AuthenticationException e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
                }
                Console.WriteLine("Authentication failed - closing the connection.");
                clients.Remove(client);
                SslStream.Close();
                client.Close();
                return;
            }
            catch(Exception)
            {
                // The client stream will be closed with the sslStream
                // because we specified this behavior when creating
                // the sslStream.
                clients.Remove(client);
                SslStream.Close();
                client.Close();
            }
        }

        //added to test sendmessages from GUI
        public void SendMessage(string json)
        {
            // Set timeouts for write to 5 seconds.
            SslStream.WriteTimeout = 5000;
            
            // Write a message to the client.
            byte[] message = Encoding.UTF8.GetBytes(json+"<EOF>");
            SslStream.Write(message);
            SslStream.Flush();
        }

        public string ReadMessage()
        {
            // Read the  message sent by the client.
            // The client signals the end of the message using the
            // "<EOF>" marker.
            byte[] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            int bytes = -1;
            do
            {
                // Read the client's test message.
                bytes = SslStream.Read(buffer, 0, buffer.Length);
                // Use Decoder class to convert from bytes to UTF8
                // in case a character spans two buffers.
                Decoder decoder = Encoding.UTF8.GetDecoder();
                char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
                decoder.GetChars(buffer, 0, bytes, chars, 0);
                messageData.Append(chars);
                // Check for EOF or an empty message.
                if (messageData.ToString().IndexOf("<EOF>") != -1)
                {
                    break;
                }
            } while (bytes != 0);

            return messageData.ToString();
        }
        static void DisplaySecurityLevel(SslStream stream)
        {
            Console.WriteLine("Cipher: {0} strength {1}", stream.CipherAlgorithm, stream.CipherStrength);
            Console.WriteLine("Hash: {0} strength {1}", stream.HashAlgorithm, stream.HashStrength);
            Console.WriteLine("Key exchange: {0} strength {1}", stream.KeyExchangeAlgorithm, stream.KeyExchangeStrength);
            Console.WriteLine("Protocol: {0}", stream.SslProtocol);
        }
        static void DisplaySecurityServices(SslStream stream)
        {
            Console.WriteLine("Is authenticated: {0} as server? {1}", stream.IsAuthenticated, stream.IsServer);
            Console.WriteLine("IsSigned: {0}", stream.IsSigned);
            Console.WriteLine("Is Encrypted: {0}", stream.IsEncrypted);
        }
        static void DisplayStreamProperties(SslStream stream)
        {
            Console.WriteLine("Can read: {0}, write {1}", stream.CanRead, stream.CanWrite);
            Console.WriteLine("Can timeout: {0}", stream.CanTimeout);
        }
        static void DisplayCertificateInformation(SslStream stream)
        {
            Console.WriteLine("Certificate revocation list checked: {0}", stream.CheckCertRevocationStatus);

            X509Certificate localCertificate = stream.LocalCertificate;
            if (stream.LocalCertificate != null)
            {
                Console.WriteLine("Local cert was issued to {0} and is valid from {1} until {2}.",
                    localCertificate.Subject,
                    localCertificate.GetEffectiveDateString(),
                    localCertificate.GetExpirationDateString());
            }
            else
            {
                Console.WriteLine("Local certificate is null.");
            }
            // Display the properties of the client's certificate.
            X509Certificate remoteCertificate = stream.RemoteCertificate;
            if (stream.RemoteCertificate != null)
            {
                Console.WriteLine("Remote cert was issued to {0} and is valid from {1} until {2}.",
                    remoteCertificate.Subject,
                    remoteCertificate.GetEffectiveDateString(),
                    remoteCertificate.GetExpirationDateString());
            }
            else
            {
                Console.WriteLine("Remote certificate is null.");
            }
        }

        public void ShutdownServer()
        {
            Listener.Stop();
        }

    }
}