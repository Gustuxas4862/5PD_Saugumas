using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PD5
{
    internal class Server
    {
        public void StartServer(TextBox connectionState, string text)
        {
            try
            {
                connectionState.Text = "Waiting for a connection...";

                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                int port = 8888;
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);

                    connectionState.Text = "Connection established to " + ipAddress.AddressFamily + " on port " + port + "." + Environment.NewLine
                        + "Hashed data successfully sent.";

                    byte[] msg = Encoding.ASCII.GetBytes(text);

                    sender.Send(msg);

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException: " + ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException: " + se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception: " + e.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered: " + ex.Message);
            }
        }
    }
}
