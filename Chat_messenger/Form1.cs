using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace Chat_messenger
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint iplocal, ipremote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Création du connecteur reseau (socket)
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Recupere l'ip des utilisateurs
            textLocalIp.Text = GetLocalIP();
            textRemoteIp.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convertie le string message en byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(pseudoAfficher.Text + " : " + textMessage.Text);

            //Envoi le message encodé
            sck.Send(sendingMessage);

            //Ajoute le message a la listbox
            string messageRecu = pseudoAfficher.Text + " : " + textMessage.Text;
            listMessage.Items.Add(messageRecu);
            textMessage.Text = "";

            //string textMessageList = pseudoAfficher.Text + " : ";
            //textMessageList += textMessage.Text;
            //listMessage.Items.Add(textMessageList);
        }

        private void enregistrerPseudo_Click(object sender, EventArgs e)
        {
            pseudoAfficher.Text = champsTextePseudo.Text;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //Liaison entre les sockets
            iplocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(iplocal);

            //Connection a l'ip de l'utilisateur distant
            ipremote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(ipremote);

            //Recois le port specifique
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipremote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //Convertie le message byte[] en string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Ajoute le message dans la Listbox
                listMessage.Items.Add(receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipremote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
    }
}