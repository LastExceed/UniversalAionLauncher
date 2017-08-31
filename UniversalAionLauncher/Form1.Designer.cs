namespace UniversalAionLauncher {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listBoxVersion = new System.Windows.Forms.ListBox();
            this.listBoxLanguage = new System.Windows.Forms.ListBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.labelPort = new System.Windows.Forms.Label();
            this.checkedListBoxParams = new System.Windows.Forms.CheckedListBox();
            this.textBoxParam = new System.Windows.Forms.TextBox();
            this.buttonParamAdd = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.listBoxProfile = new System.Windows.Forms.ListBox();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.buttonServerNew = new System.Windows.Forms.Button();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.buttonServerRemove = new System.Windows.Forms.Button();
            this.groupBoxLaunchParams = new System.Windows.Forms.GroupBox();
            this.buttonParamRemove = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.numericUpDownCC = new System.Windows.Forms.NumericUpDown();
            this.labelCC = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelStatusPing = new System.Windows.Forms.Label();
            this.labelStatusChat = new System.Windows.Forms.Label();
            this.labelStatusGame = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelNotice = new System.Windows.Forms.Label();
            this.labelLoginServer = new System.Windows.Forms.Label();
            this.labelGameserver = new System.Windows.Forms.Label();
            this.labelChatserver = new System.Windows.Forms.Label();
            this.labelPing = new System.Windows.Forms.Label();
            this.labelStatusLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBoxServer.SuspendLayout();
            this.groupBoxLaunchParams.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCC)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVersion
            // 
            this.listBoxVersion.FormattingEnabled = true;
            this.listBoxVersion.Location = new System.Drawing.Point(2, 14);
            this.listBoxVersion.Name = "listBoxVersion";
            this.listBoxVersion.Size = new System.Drawing.Size(64, 69);
            this.listBoxVersion.TabIndex = 2;
            this.listBoxVersion.SelectedIndexChanged += new System.EventHandler(this.ListBoxVersion_SelectedIndexChanged);
            // 
            // listBoxLanguage
            // 
            this.listBoxLanguage.Enabled = false;
            this.listBoxLanguage.FormattingEnabled = true;
            this.listBoxLanguage.Location = new System.Drawing.Point(67, 14);
            this.listBoxLanguage.Name = "listBoxLanguage";
            this.listBoxLanguage.Size = new System.Drawing.Size(64, 69);
            this.listBoxLanguage.TabIndex = 3;
            this.listBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ListBoxLanguage_SelectedIndexChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(21, 84);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(110, 20);
            this.textBoxIP.TabIndex = 6;
            this.textBoxIP.TextChanged += new System.EventHandler(this.TextBoxIP_TextChanged);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(21, 105);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownPort.TabIndex = 7;
            this.numericUpDownPort.Value = new decimal(new int[] {
            2106,
            0,
            0,
            0});
            this.numericUpDownPort.ValueChanged += new System.EventHandler(this.NumericUpDownPort_ValueChanged);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(2, 108);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(21, 12);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "port";
            // 
            // checkedListBoxParams
            // 
            this.checkedListBoxParams.FormattingEnabled = true;
            this.checkedListBoxParams.Items.AddRange(new object[] {
            "charnamemenu",
            "ingamebrowser",
            "ingameshop",
            "ls",
            "ncg",
            "nokicks",
            "noauthgg",
            "noweb",
            "nowebshop",
            "st"});
            this.checkedListBoxParams.Location = new System.Drawing.Point(2, 14);
            this.checkedListBoxParams.Name = "checkedListBoxParams";
            this.checkedListBoxParams.Size = new System.Drawing.Size(120, 79);
            this.checkedListBoxParams.TabIndex = 11;
            this.checkedListBoxParams.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxParams_SelectedIndexChanged);
            // 
            // textBoxParam
            // 
            this.textBoxParam.Enabled = false;
            this.textBoxParam.Location = new System.Drawing.Point(2, 94);
            this.textBoxParam.Multiline = true;
            this.textBoxParam.Name = "textBoxParam";
            this.textBoxParam.Size = new System.Drawing.Size(101, 32);
            this.textBoxParam.TabIndex = 13;
            this.textBoxParam.TextChanged += new System.EventHandler(this.TextBoxParam_TextChanged);
            // 
            // buttonParamAdd
            // 
            this.buttonParamAdd.Location = new System.Drawing.Point(103, 93);
            this.buttonParamAdd.Name = "buttonParamAdd";
            this.buttonParamAdd.Size = new System.Drawing.Size(20, 18);
            this.buttonParamAdd.TabIndex = 14;
            this.buttonParamAdd.Text = "+";
            this.buttonParamAdd.UseVisualStyleBackColor = true;
            this.buttonParamAdd.Click += new System.EventHandler(this.ButtonParamAdd_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecute.Location = new System.Drawing.Point(417, 127);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(55, 47);
            this.buttonExecute.TabIndex = 15;
            this.buttonExecute.Text = "play";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // listBoxProfile
            // 
            this.listBoxProfile.FormattingEnabled = true;
            this.listBoxProfile.Location = new System.Drawing.Point(2, 14);
            this.listBoxProfile.Name = "listBoxProfile";
            this.listBoxProfile.Size = new System.Drawing.Size(97, 69);
            this.listBoxProfile.TabIndex = 16;
            this.listBoxProfile.Click += new System.EventHandler(this.ListBoxProfile_Click);
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.buttonServerNew);
            this.groupBoxServer.Controls.Add(this.textBoxProfile);
            this.groupBoxServer.Controls.Add(this.buttonServerRemove);
            this.groupBoxServer.Controls.Add(this.listBoxProfile);
            this.groupBoxServer.Location = new System.Drawing.Point(1, -1);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(101, 129);
            this.groupBoxServer.TabIndex = 17;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "profile";
            // 
            // buttonServerNew
            // 
            this.buttonServerNew.Location = new System.Drawing.Point(1, 104);
            this.buttonServerNew.Name = "buttonServerNew";
            this.buttonServerNew.Size = new System.Drawing.Size(50, 23);
            this.buttonServerNew.TabIndex = 18;
            this.buttonServerNew.Text = "new";
            this.buttonServerNew.UseVisualStyleBackColor = true;
            this.buttonServerNew.Click += new System.EventHandler(this.ButtonProfileNew_Click);
            // 
            // textBoxProfile
            // 
            this.textBoxProfile.Enabled = false;
            this.textBoxProfile.Location = new System.Drawing.Point(2, 84);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(97, 20);
            this.textBoxProfile.TabIndex = 17;
            this.textBoxProfile.TextChanged += new System.EventHandler(this.TextBoxProfile_TextChanged);
            // 
            // buttonServerRemove
            // 
            this.buttonServerRemove.Enabled = false;
            this.buttonServerRemove.Location = new System.Drawing.Point(50, 104);
            this.buttonServerRemove.Name = "buttonServerRemove";
            this.buttonServerRemove.Size = new System.Drawing.Size(50, 23);
            this.buttonServerRemove.TabIndex = 19;
            this.buttonServerRemove.Text = "remove";
            this.buttonServerRemove.UseVisualStyleBackColor = true;
            this.buttonServerRemove.Click += new System.EventHandler(this.ButtonProfileRemove_Click);
            // 
            // groupBoxLaunchParams
            // 
            this.groupBoxLaunchParams.Controls.Add(this.buttonParamRemove);
            this.groupBoxLaunchParams.Controls.Add(this.checkedListBoxParams);
            this.groupBoxLaunchParams.Controls.Add(this.textBoxParam);
            this.groupBoxLaunchParams.Controls.Add(this.buttonParamAdd);
            this.groupBoxLaunchParams.Enabled = false;
            this.groupBoxLaunchParams.Location = new System.Drawing.Point(235, -1);
            this.groupBoxLaunchParams.Name = "groupBoxLaunchParams";
            this.groupBoxLaunchParams.Size = new System.Drawing.Size(124, 129);
            this.groupBoxLaunchParams.TabIndex = 18;
            this.groupBoxLaunchParams.TabStop = false;
            this.groupBoxLaunchParams.Text = "launch parameters";
            // 
            // buttonParamRemove
            // 
            this.buttonParamRemove.Enabled = false;
            this.buttonParamRemove.Location = new System.Drawing.Point(103, 110);
            this.buttonParamRemove.Name = "buttonParamRemove";
            this.buttonParamRemove.Size = new System.Drawing.Size(20, 17);
            this.buttonParamRemove.TabIndex = 22;
            this.buttonParamRemove.Text = "-";
            this.buttonParamRemove.UseVisualStyleBackColor = true;
            this.buttonParamRemove.Click += new System.EventHandler(this.ButtonParamRemove_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.labelIP);
            this.groupBoxClient.Controls.Add(this.numericUpDownCC);
            this.groupBoxClient.Controls.Add(this.listBoxVersion);
            this.groupBoxClient.Controls.Add(this.labelCC);
            this.groupBoxClient.Controls.Add(this.numericUpDownPort);
            this.groupBoxClient.Controls.Add(this.listBoxLanguage);
            this.groupBoxClient.Controls.Add(this.textBoxIP);
            this.groupBoxClient.Controls.Add(this.labelPort);
            this.groupBoxClient.Enabled = false;
            this.groupBoxClient.Location = new System.Drawing.Point(102, -1);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(133, 129);
            this.groupBoxClient.TabIndex = 19;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "client";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(6, 89);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(15, 12);
            this.labelIP.TabIndex = 18;
            this.labelIP.Text = "ip:";
            // 
            // numericUpDownCC
            // 
            this.numericUpDownCC.Location = new System.Drawing.Point(105, 105);
            this.numericUpDownCC.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCC.Name = "numericUpDownCC";
            this.numericUpDownCC.Size = new System.Drawing.Size(26, 20);
            this.numericUpDownCC.TabIndex = 16;
            this.numericUpDownCC.ValueChanged += new System.EventHandler(this.NumericUpDownCC_ValueChanged);
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.Location = new System.Drawing.Point(70, 102);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(36, 24);
            this.labelCC.TabIndex = 17;
            this.labelCC.Text = "country\r\ncode:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(1, 128);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(416, 45);
            this.textBoxOutput.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelStatusPing);
            this.groupBoxStatus.Controls.Add(this.labelStatusChat);
            this.groupBoxStatus.Controls.Add(this.labelStatusGame);
            this.groupBoxStatus.Controls.Add(this.buttonRefresh);
            this.groupBoxStatus.Controls.Add(this.progressBar1);
            this.groupBoxStatus.Controls.Add(this.labelNotice);
            this.groupBoxStatus.Controls.Add(this.labelLoginServer);
            this.groupBoxStatus.Controls.Add(this.labelGameserver);
            this.groupBoxStatus.Controls.Add(this.labelChatserver);
            this.groupBoxStatus.Controls.Add(this.labelPing);
            this.groupBoxStatus.Controls.Add(this.labelStatusLogin);
            this.groupBoxStatus.Location = new System.Drawing.Point(359, -1);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(112, 129);
            this.groupBoxStatus.TabIndex = 21;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "server status";
            // 
            // labelStatusPing
            // 
            this.labelStatusPing.AutoSize = true;
            this.labelStatusPing.ForeColor = System.Drawing.Color.Black;
            this.labelStatusPing.Location = new System.Drawing.Point(71, 66);
            this.labelStatusPing.Name = "labelStatusPing";
            this.labelStatusPing.Size = new System.Drawing.Size(19, 13);
            this.labelStatusPing.TabIndex = 9;
            this.labelStatusPing.Text = "??";
            // 
            // labelStatusChat
            // 
            this.labelStatusChat.AutoSize = true;
            this.labelStatusChat.ForeColor = System.Drawing.Color.Black;
            this.labelStatusChat.Location = new System.Drawing.Point(71, 53);
            this.labelStatusChat.Name = "labelStatusChat";
            this.labelStatusChat.Size = new System.Drawing.Size(19, 13);
            this.labelStatusChat.TabIndex = 8;
            this.labelStatusChat.Text = "??";
            // 
            // labelStatusGame
            // 
            this.labelStatusGame.AutoSize = true;
            this.labelStatusGame.ForeColor = System.Drawing.Color.Black;
            this.labelStatusGame.Location = new System.Drawing.Point(71, 41);
            this.labelStatusGame.Name = "labelStatusGame";
            this.labelStatusGame.Size = new System.Drawing.Size(19, 13);
            this.labelStatusGame.TabIndex = 7;
            this.labelStatusGame.Text = "??";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(64, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(47, 19);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 12);
            this.progressBar1.Maximum = 4;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(62, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotice.Location = new System.Drawing.Point(1, 79);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(110, 48);
            this.labelNotice.TabIndex = 4;
            this.labelNotice.Text = "(if the servers don\'t run all\r\non the same IP and under\r\nthe default ports this w" +
    "ill\r\nalways show \"offline\")";
            // 
            // labelLoginServer
            // 
            this.labelLoginServer.AutoSize = true;
            this.labelLoginServer.Location = new System.Drawing.Point(5, 29);
            this.labelLoginServer.Name = "labelLoginServer";
            this.labelLoginServer.Size = new System.Drawing.Size(64, 13);
            this.labelLoginServer.TabIndex = 0;
            this.labelLoginServer.Text = "login-server:";
            // 
            // labelGameserver
            // 
            this.labelGameserver.AutoSize = true;
            this.labelGameserver.Location = new System.Drawing.Point(1, 41);
            this.labelGameserver.Name = "labelGameserver";
            this.labelGameserver.Size = new System.Drawing.Size(68, 13);
            this.labelGameserver.TabIndex = 1;
            this.labelGameserver.Text = "game-server;";
            // 
            // labelChatserver
            // 
            this.labelChatserver.AutoSize = true;
            this.labelChatserver.Location = new System.Drawing.Point(6, 53);
            this.labelChatserver.Name = "labelChatserver";
            this.labelChatserver.Size = new System.Drawing.Size(63, 13);
            this.labelChatserver.TabIndex = 2;
            this.labelChatserver.Text = "chat-server;";
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = true;
            this.labelPing.Location = new System.Drawing.Point(39, 65);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(30, 13);
            this.labelPing.TabIndex = 3;
            this.labelPing.Text = "ping:";
            // 
            // labelStatusLogin
            // 
            this.labelStatusLogin.AutoSize = true;
            this.labelStatusLogin.ForeColor = System.Drawing.Color.Black;
            this.labelStatusLogin.Location = new System.Drawing.Point(71, 29);
            this.labelStatusLogin.Name = "labelStatusLogin";
            this.labelStatusLogin.Size = new System.Drawing.Size(19, 13);
            this.labelStatusLogin.TabIndex = 6;
            this.labelStatusLogin.Text = "??";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 174);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxLaunchParams);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Universal Aion Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.groupBoxLaunchParams.ResumeLayout(false);
            this.groupBoxLaunchParams.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCC)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxVersion;
        private System.Windows.Forms.ListBox listBoxLanguage;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.CheckedListBox checkedListBoxParams;
        private System.Windows.Forms.TextBox textBoxParam;
        private System.Windows.Forms.Button buttonParamAdd;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.ListBox listBoxProfile;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.Button buttonServerNew;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.Button buttonServerRemove;
        private System.Windows.Forms.GroupBox groupBoxLaunchParams;
        private System.Windows.Forms.Button buttonParamRemove;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.NumericUpDown numericUpDownCC;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelStatusPing;
        private System.Windows.Forms.Label labelStatusChat;
        private System.Windows.Forms.Label labelStatusGame;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.Label labelLoginServer;
        private System.Windows.Forms.Label labelGameserver;
        private System.Windows.Forms.Label labelChatserver;
        private System.Windows.Forms.Label labelPing;
        private System.Windows.Forms.Label labelStatusLogin;
    }
}

