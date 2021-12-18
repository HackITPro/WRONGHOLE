using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.RegularExpressions;


namespace Wronghole
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {

            // Create about button form 
            Form aboutForm = new Form()
            {
                StartPosition = FormStartPosition.CenterParent,
                Text = "WRONGHOLE",
                Size = new Size(250, 200),
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle
            };

            // Add text to form via a label centered in the form box
            Label aboutLabel = new Label()
            {
                Text = "WRONGHOLE \n\nVersion: 0.1 \n\nDevs: Deez && Mercy",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Set label font to project standard
            aboutLabel.Font = new Font("Arial Rounded MT", 12, FontStyle.Regular);

            // Add label to aboutForm and show dialog box on screen
            aboutForm.Controls.Add(aboutLabel);
            aboutForm.Icon = Properties.Resources.penis_QhJ_icon;
            aboutForm.ShowDialog();

        }

        //Server array so we can access it later for manipulation
        List<SslTcpServer> servers = new List<SslTcpServer>();

        private void Submitbutton1_Click(object sender, EventArgs e)
        {
            string proto = protoConnect.SelectedItem.ToString();
            string ip = ipConnect.Text;
            string port = portConnect.Text;
            string cert = certBox.Text;
            if (listenButton1.Checked)
            {
                //Check user input with regex
                var ipMatch = Regex.Match(ip, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b" , RegexOptions.IgnoreCase);
                var portMatch = Regex.Match(port, "^([0-9]{1,4}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$" , RegexOptions.IgnoreCase);

                if (ipMatch.Success && portMatch.Success)
                {
                    if (proto == "TCP")
                    {
                        SslTcpServer s = new SslTcpServer(cert, ip, port);
                        //Add servers to list
                        servers.Add(s);
                        //Start server instance in separate thread as a task so GUI process doesn't block.
                        Task tsk = Task.Factory.StartNew(() => s.RunServer());
                        tsk.ContinueWith(i =>
                        {
                            MessageBox.Show("Interface doesn't exist or port already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            servers.Remove(s);

                        }, TaskContinuationOptions.OnlyOnFaulted);
                                                
                    }

                    ipConnect.Clear();
                    portConnect.Clear();
                    certBox.Clear();
                    protoConnect.SelectedItem = null;

                }
                else
                {
                    //Incorrect IP/Port format message box
                    MessageBox.Show("Incorrect IP/Port. Check format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }         

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit button functionality
            System.Windows.Forms.Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            //Clear serverBox and activeGridView
            serverBox1.Items.Clear();
            activeGridView1.Rows.Clear();

            //Loop and populate both serverBox and activeGridView with data
            foreach (SslTcpServer i in servers)
            {
                serverBox1.Items.Add(String.Format("Ip: {0} ---- Port: {1}", i.Ip,i.Port));
                               
                try
                {
                    foreach (TcpClient x in i.clients)
                    {
                        string[] row = { Convert.ToString(x.Client.LocalEndPoint), Convert.ToString(x.Client.RemoteEndPoint), Convert.ToString(x.Client.Connected)};
                        activeGridView1.Rows.Add(row);

                    }
                }

                //Race condition causing error due to updating list during loop, don't care....throw
                catch(Exception)
                {
                    throw;
                }
            }
        }

        private void ServerBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //Get location of mouse and save as index
                int index = this.serverBox1.IndexFromPoint(e.Location);

                //Create ContextMenuStrip for right click eventhandler and add menu items
                ContextMenuStrip cm = new ContextMenuStrip()
                {
                    AutoSize = false,
                    Width = 110,
                    Height = 25

                };

                //Create Buttons
                ToolStripButton disconnect = new ToolStripButton("Disconnect");

                //Add items to contextmenustrip
                cm.Items.AddRange(new ToolStripItem[] { disconnect });

                //Show menu
                if (index != ListBox.NoMatches)
                {
                    //Show ContextMenuStrip only if item is in list
                    cm.Show(serverBox1, new Point(e.X, e.Y));
                }

                //Adding menu event handler
                disconnect.Click += (s, eventArgs) =>
                {
                    //Shutdown selected server                
                    servers[index].ShutdownServer();
                    servers.Remove(servers[index]);
                };

            }
                       
        }

        private void CertButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            certBox.Text = openFileDialog1.FileName;
        }

        private void ActiveGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Set column/row index and variables, store endPoint and localEndpoint of selected row
            int columnSelect = e.ColumnIndex, rowSelect = e.RowIndex;
            String endPoint = "", localEndpoint = "";
            SslTcpServer session = null;

           //Check if columnSelect is equal to first column on dataGridView and not first row
            if (columnSelect == -1  && rowSelect != -1)
            {                
                foreach (SslTcpServer i in servers)
                {
                    foreach (TcpClient x in i.clients)
                    {                        
                        string remoteEndpoint = activeGridView1.Rows[rowSelect].Cells[1].FormattedValue.ToString();
                        Console.WriteLine(remoteEndpoint);
                        if (remoteEndpoint == Convert.ToString(x.Client.RemoteEndPoint))
                        {
                            endPoint = Convert.ToString(x.Client.RemoteEndPoint);
                            localEndpoint = Convert.ToString(x.Client.LocalEndPoint);
                            session = i;
                        }
                    }
                }

                //Create new form2
                Form2 consoleForm = new Form2(session)
                {
                    Text = localEndpoint + " <-> " + endPoint                   
                };
                
                //Show form2
                consoleForm.Show();
                
            }

        }
    }

}