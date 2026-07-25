using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal class Server
    {
        private Socket socket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

            socket.Bind(endPoint);
            socket.Listen(5);

            Thread acceptClientsThread = new Thread(AcceptClient);
            acceptClientsThread.IsBackground = true;
            acceptClientsThread.Start();
        }

        private void AcceptClient(object? obj)
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket, klijenti);
                    klijenti.Add(handler);

                    Thread nitKlijenta = new Thread(handler.Handle);
                    nitKlijenta.IsBackground = true;
                    nitKlijenta.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine("SE>>> " + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine("IOE>>> " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void Stop()
        {
            foreach (var klijent in klijenti)
            {
                klijent.Close();
            }

            klijenti.Clear();
            socket?.Close();
        }
    }
}