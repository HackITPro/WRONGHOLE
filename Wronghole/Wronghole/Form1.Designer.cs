using System;

namespace Wronghole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buildTab = new System.Windows.Forms.TabPage();
            this.buildbutton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.protoImplant = new System.Windows.Forms.ComboBox();
            this.portImplant = new System.Windows.Forms.TextBox();
            this.ipImplant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.callbackButton1 = new System.Windows.Forms.RadioButton();
            this.connectbuildButton2 = new System.Windows.Forms.RadioButton();
            this.connTab = new System.Windows.Forms.TabPage();
            this.certButton = new System.Windows.Forms.Button();
            this.certBox = new System.Windows.Forms.TextBox();
            this.serverBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.protoConnect = new System.Windows.Forms.ComboBox();
            this.portConnect = new System.Windows.Forms.TextBox();
            this.ipConnect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitbutton1 = new System.Windows.Forms.Button();
            this.connectButton2 = new System.Windows.Forms.RadioButton();
            this.listenButton1 = new System.Windows.Forms.RadioButton();
            this.activeConn = new System.Windows.Forms.TabPage();
            this.activeGridView1 = new System.Windows.Forms.DataGridView();
            this.addrPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connBoolean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataViewTab = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fileToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hackToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.prefToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buildTab.SuspendLayout();
            this.connTab.SuspendLayout();
            this.activeConn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildTab
            // 
            this.buildTab.BackColor = System.Drawing.Color.Black;
            this.buildTab.Controls.Add(this.buildbutton1);
            this.buildTab.Controls.Add(this.label4);
            this.buildTab.Controls.Add(this.protoImplant);
            this.buildTab.Controls.Add(this.portImplant);
            this.buildTab.Controls.Add(this.ipImplant);
            this.buildTab.Controls.Add(this.label5);
            this.buildTab.Controls.Add(this.label6);
            this.buildTab.Controls.Add(this.callbackButton1);
            this.buildTab.Controls.Add(this.connectbuildButton2);
            this.buildTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildTab.Location = new System.Drawing.Point(4, 24);
            this.buildTab.Name = "buildTab";
            this.buildTab.Padding = new System.Windows.Forms.Padding(3);
            this.buildTab.Size = new System.Drawing.Size(1448, 712);
            this.buildTab.TabIndex = 2;
            this.buildTab.Text = "Build Implants";
            // 
            // buildbutton1
            // 
            this.buildbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildbutton1.Location = new System.Drawing.Point(1336, 676);
            this.buildbutton1.Name = "buildbutton1";
            this.buildbutton1.Size = new System.Drawing.Size(104, 23);
            this.buildbutton1.TabIndex = 15;
            this.buildbutton1.Text = "Build";
            this.buildbutton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Protocol:";
            // 
            // protoImplant
            // 
            this.protoImplant.BackColor = System.Drawing.Color.Black;
            this.protoImplant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.protoImplant.FormattingEnabled = true;
            this.protoImplant.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "DNS",
            "LDAP"});
            this.protoImplant.Location = new System.Drawing.Point(107, 114);
            this.protoImplant.Name = "protoImplant";
            this.protoImplant.Size = new System.Drawing.Size(151, 24);
            this.protoImplant.TabIndex = 13;
            // 
            // portImplant
            // 
            this.portImplant.BackColor = System.Drawing.Color.Black;
            this.portImplant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portImplant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.portImplant.Location = new System.Drawing.Point(107, 76);
            this.portImplant.MaxLength = 50;
            this.portImplant.Name = "portImplant";
            this.portImplant.Size = new System.Drawing.Size(151, 23);
            this.portImplant.TabIndex = 12;
            this.portImplant.WordWrap = false;
            // 
            // ipImplant
            // 
            this.ipImplant.BackColor = System.Drawing.Color.Black;
            this.ipImplant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipImplant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ipImplant.Location = new System.Drawing.Point(107, 41);
            this.ipImplant.MaxLength = 50;
            this.ipImplant.Name = "ipImplant";
            this.ipImplant.Size = new System.Drawing.Size(151, 23);
            this.ipImplant.TabIndex = 9;
            this.ipImplant.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "IP Address:";
            // 
            // callbackButton1
            // 
            this.callbackButton1.AutoSize = true;
            this.callbackButton1.Location = new System.Drawing.Point(81, 6);
            this.callbackButton1.Name = "callbackButton1";
            this.callbackButton1.Size = new System.Drawing.Size(79, 20);
            this.callbackButton1.TabIndex = 3;
            this.callbackButton1.Text = "Callback";
            this.callbackButton1.UseVisualStyleBackColor = true;
            // 
            // connectbuildButton2
            // 
            this.connectbuildButton2.AutoSize = true;
            this.connectbuildButton2.Location = new System.Drawing.Point(5, 6);
            this.connectbuildButton2.Name = "connectbuildButton2";
            this.connectbuildButton2.Size = new System.Drawing.Size(61, 20);
            this.connectbuildButton2.TabIndex = 2;
            this.connectbuildButton2.Text = "Listen";
            this.connectbuildButton2.UseVisualStyleBackColor = true;
            // 
            // connTab
            // 
            this.connTab.BackColor = System.Drawing.Color.Black;
            this.connTab.Controls.Add(this.certButton);
            this.connTab.Controls.Add(this.certBox);
            this.connTab.Controls.Add(this.serverBox1);
            this.connTab.Controls.Add(this.label3);
            this.connTab.Controls.Add(this.protoConnect);
            this.connTab.Controls.Add(this.portConnect);
            this.connTab.Controls.Add(this.ipConnect);
            this.connTab.Controls.Add(this.label2);
            this.connTab.Controls.Add(this.label1);
            this.connTab.Controls.Add(this.submitbutton1);
            this.connTab.Controls.Add(this.connectButton2);
            this.connTab.Controls.Add(this.listenButton1);
            this.connTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connTab.Location = new System.Drawing.Point(4, 24);
            this.connTab.Name = "connTab";
            this.connTab.Padding = new System.Windows.Forms.Padding(3);
            this.connTab.Size = new System.Drawing.Size(1448, 712);
            this.connTab.TabIndex = 1;
            this.connTab.Text = "Connect";
            // 
            // certButton
            // 
            this.certButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.certButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certButton.Location = new System.Drawing.Point(8, 205);
            this.certButton.Name = "certButton";
            this.certButton.Size = new System.Drawing.Size(247, 23);
            this.certButton.TabIndex = 11;
            this.certButton.Text = "Select Cert";
            this.certButton.UseVisualStyleBackColor = false;
            this.certButton.Click += new System.EventHandler(this.CertButton_Click);
            // 
            // certBox
            // 
            this.certBox.BackColor = System.Drawing.Color.Black;
            this.certBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.certBox.Location = new System.Drawing.Point(8, 176);
            this.certBox.MaxLength = 50;
            this.certBox.Name = "certBox";
            this.certBox.Size = new System.Drawing.Size(247, 23);
            this.certBox.TabIndex = 10;
            this.certBox.WordWrap = false;
            // 
            // serverBox1
            // 
            this.serverBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverBox1.BackColor = System.Drawing.Color.Black;
            this.serverBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.serverBox1.FormattingEnabled = true;
            this.serverBox1.ItemHeight = 15;
            this.serverBox1.Location = new System.Drawing.Point(298, 6);
            this.serverBox1.Name = "serverBox1";
            this.serverBox1.Size = new System.Drawing.Size(1142, 649);
            this.serverBox1.TabIndex = 9;
            this.serverBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerBox1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Protocol:";
            // 
            // protoConnect
            // 
            this.protoConnect.BackColor = System.Drawing.Color.Black;
            this.protoConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.protoConnect.FormattingEnabled = true;
            this.protoConnect.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "DNS",
            "LDAP"});
            this.protoConnect.Location = new System.Drawing.Point(104, 130);
            this.protoConnect.Name = "protoConnect";
            this.protoConnect.Size = new System.Drawing.Size(151, 24);
            this.protoConnect.TabIndex = 7;
            // 
            // portConnect
            // 
            this.portConnect.BackColor = System.Drawing.Color.Black;
            this.portConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.portConnect.Location = new System.Drawing.Point(104, 92);
            this.portConnect.MaxLength = 50;
            this.portConnect.Name = "portConnect";
            this.portConnect.Size = new System.Drawing.Size(151, 23);
            this.portConnect.TabIndex = 6;
            this.portConnect.WordWrap = false;
            // 
            // ipConnect
            // 
            this.ipConnect.BackColor = System.Drawing.Color.Black;
            this.ipConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ipConnect.Location = new System.Drawing.Point(104, 57);
            this.ipConnect.MaxLength = 50;
            this.ipConnect.Name = "ipConnect";
            this.ipConnect.Size = new System.Drawing.Size(151, 23);
            this.ipConnect.TabIndex = 2;
            this.ipConnect.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address:";
            // 
            // submitbutton1
            // 
            this.submitbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton1.Location = new System.Drawing.Point(1330, 676);
            this.submitbutton1.Name = "submitbutton1";
            this.submitbutton1.Size = new System.Drawing.Size(104, 23);
            this.submitbutton1.TabIndex = 3;
            this.submitbutton1.Text = "Submit";
            this.submitbutton1.UseVisualStyleBackColor = true;
            this.submitbutton1.Click += new System.EventHandler(this.Submitbutton1_Click);
            // 
            // connectButton2
            // 
            this.connectButton2.AutoSize = true;
            this.connectButton2.Location = new System.Drawing.Point(84, 6);
            this.connectButton2.Name = "connectButton2";
            this.connectButton2.Size = new System.Drawing.Size(75, 20);
            this.connectButton2.TabIndex = 1;
            this.connectButton2.Text = "Connect";
            this.connectButton2.UseVisualStyleBackColor = true;
            // 
            // listenButton1
            // 
            this.listenButton1.AutoSize = true;
            this.listenButton1.Checked = true;
            this.listenButton1.Location = new System.Drawing.Point(8, 6);
            this.listenButton1.Name = "listenButton1";
            this.listenButton1.Size = new System.Drawing.Size(61, 20);
            this.listenButton1.TabIndex = 0;
            this.listenButton1.TabStop = true;
            this.listenButton1.Text = "Listen";
            this.listenButton1.UseVisualStyleBackColor = true;
            // 
            // activeConn
            // 
            this.activeConn.BackColor = System.Drawing.Color.Black;
            this.activeConn.Controls.Add(this.activeGridView1);
            this.activeConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeConn.Location = new System.Drawing.Point(4, 24);
            this.activeConn.Name = "activeConn";
            this.activeConn.Padding = new System.Windows.Forms.Padding(3);
            this.activeConn.Size = new System.Drawing.Size(1448, 712);
            this.activeConn.TabIndex = 0;
            this.activeConn.Text = "Active Connections";
            // 
            // activeGridView1
            // 
            this.activeGridView1.AllowUserToAddRows = false;
            this.activeGridView1.AllowUserToDeleteRows = false;
            this.activeGridView1.AllowUserToResizeColumns = false;
            this.activeGridView1.AllowUserToResizeRows = false;
            this.activeGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.activeGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addrPort,
            this.remoteIP,
            this.connBoolean});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activeGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.activeGridView1.GridColor = System.Drawing.Color.Gray;
            this.activeGridView1.Location = new System.Drawing.Point(3, 3);
            this.activeGridView1.Name = "activeGridView1";
            this.activeGridView1.Size = new System.Drawing.Size(1442, 706);
            this.activeGridView1.TabIndex = 1;
            this.activeGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ActiveGridView1_CellMouseDown);
            // 
            // addrPort
            // 
            this.addrPort.HeaderText = "Local IP:Port";
            this.addrPort.Name = "addrPort";
            this.addrPort.ReadOnly = true;
            this.addrPort.Width = 250;
            // 
            // remoteIP
            // 
            this.remoteIP.HeaderText = "Remote IP:Port";
            this.remoteIP.Name = "remoteIP";
            this.remoteIP.ReadOnly = true;
            this.remoteIP.Width = 200;
            // 
            // connBoolean
            // 
            this.connBoolean.HeaderText = "Connected?";
            this.connBoolean.Name = "connBoolean";
            this.connBoolean.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.activeConn);
            this.tabControl1.Controls.Add(this.connTab);
            this.tabControl1.Controls.Add(this.buildTab);
            this.tabControl1.Controls.Add(this.dataViewTab);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1456, 740);
            this.tabControl1.TabIndex = 1;
            // 
            // dataViewTab
            // 
            this.dataViewTab.BackColor = System.Drawing.Color.Black;
            this.dataViewTab.Location = new System.Drawing.Point(4, 24);
            this.dataViewTab.Name = "dataViewTab";
            this.dataViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTab.Size = new System.Drawing.Size(1448, 712);
            this.dataViewTab.TabIndex = 3;
            this.dataViewTab.Text = "Data Viewer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fileToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(40, 22);
            this.fileToolStrip.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // hackToolStrip
            // 
            this.hackToolStrip.BackColor = System.Drawing.Color.Black;
            this.hackToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hackToolStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hackToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hackToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hackToolStrip.Name = "hackToolStrip";
            this.hackToolStrip.Size = new System.Drawing.Size(68, 22);
            this.hackToolStrip.Text = "Settings";
            // 
            // prefToolStrip
            // 
            this.prefToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.prefToolStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prefToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prefToolStrip.Name = "prefToolStrip";
            this.prefToolStrip.Size = new System.Drawing.Size(91, 22);
            this.prefToolStrip.Text = "Preferences";
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aboutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(46, 22);
            this.aboutToolStrip.Text = "About";
            this.aboutToolStrip.Click += new System.EventHandler(this.AboutToolStrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.hackToolStrip,
            this.prefToolStrip,
            this.aboutToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1456, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select Cert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1456, 768);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WRONGHOLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buildTab.ResumeLayout(false);
            this.buildTab.PerformLayout();
            this.connTab.ResumeLayout(false);
            this.connTab.PerformLayout();
            this.activeConn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activeGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage buildTab;
        private System.Windows.Forms.Button buildbutton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox protoImplant;
        private System.Windows.Forms.TextBox portImplant;
        private System.Windows.Forms.TextBox ipImplant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton callbackButton1;
        private System.Windows.Forms.RadioButton connectbuildButton2;
        private System.Windows.Forms.TabPage connTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox protoConnect;
        private System.Windows.Forms.TextBox portConnect;
        private System.Windows.Forms.TextBox ipConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitbutton1;
        private System.Windows.Forms.RadioButton connectButton2;
        private System.Windows.Forms.RadioButton listenButton1;
        private System.Windows.Forms.TabPage activeConn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dataViewTab;
        private System.Windows.Forms.ListBox serverBox1;
        private System.Windows.Forms.DataGridView activeGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn connBoolean;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton hackToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton prefToolStrip;
        private System.Windows.Forms.ToolStripButton aboutToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox certBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button certButton;
    }
}

