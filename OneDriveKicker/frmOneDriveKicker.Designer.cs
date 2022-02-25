namespace OneDriveKicker
{
    partial class frmOneDriveKicker
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOneDriveKicker));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtWatchFolder = new System.Windows.Forms.TextBox();
            this.lblWatchFolder = new System.Windows.Forms.Label();
            this.btnWatchFolder = new System.Windows.Forms.Button();
            this.chkWatchFolder_SubFolders = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOneDriveFolder = new System.Windows.Forms.Label();
            this.txtOneDriveFolder = new System.Windows.Forms.TextBox();
            this.btnOneDriveFolder = new System.Windows.Forms.Button();
            this.txtDelayUpdate = new System.Windows.Forms.TextBox();
            this.lblDelayUpdate = new System.Windows.Forms.Label();
            this.txtDelayOverride = new System.Windows.Forms.TextBox();
            this.lblDelayOverride = new System.Windows.Forms.Label();
            this.barUpdateAfter = new System.Windows.Forms.ProgressBar();
            this.barMaster = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnKick = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblDelayUpdateDescp = new System.Windows.Forms.Label();
            this.lblDelayOverrideDescp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OneDriveKicker";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // txtWatchFolder
            // 
            this.txtWatchFolder.Location = new System.Drawing.Point(144, 48);
            this.txtWatchFolder.Multiline = true;
            this.txtWatchFolder.Name = "txtWatchFolder";
            this.txtWatchFolder.Size = new System.Drawing.Size(301, 26);
            this.txtWatchFolder.TabIndex = 0;
            this.txtWatchFolder.TextChanged += new System.EventHandler(this.txtWatchFolder_TextChanged);
            // 
            // lblWatchFolder
            // 
            this.lblWatchFolder.AutoSize = true;
            this.lblWatchFolder.Location = new System.Drawing.Point(16, 51);
            this.lblWatchFolder.Name = "lblWatchFolder";
            this.lblWatchFolder.Size = new System.Drawing.Size(126, 20);
            this.lblWatchFolder.TabIndex = 1;
            this.lblWatchFolder.Text = "Folder to Monitor";
            this.lblWatchFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnWatchFolder
            // 
            this.btnWatchFolder.Location = new System.Drawing.Point(451, 46);
            this.btnWatchFolder.Name = "btnWatchFolder";
            this.btnWatchFolder.Size = new System.Drawing.Size(94, 29);
            this.btnWatchFolder.TabIndex = 1;
            this.btnWatchFolder.Text = "Browse";
            this.btnWatchFolder.UseVisualStyleBackColor = true;
            this.btnWatchFolder.Click += new System.EventHandler(this.btnWatchFolder_Click);
            // 
            // chkWatchFolder_SubFolders
            // 
            this.chkWatchFolder_SubFolders.AutoSize = true;
            this.chkWatchFolder_SubFolders.Checked = true;
            this.chkWatchFolder_SubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWatchFolder_SubFolders.Location = new System.Drawing.Point(572, 49);
            this.chkWatchFolder_SubFolders.Name = "chkWatchFolder_SubFolders";
            this.chkWatchFolder_SubFolders.Size = new System.Drawing.Size(156, 24);
            this.chkWatchFolder_SubFolders.TabIndex = 2;
            this.chkWatchFolder_SubFolders.Text = "Include SubFolders";
            this.chkWatchFolder_SubFolders.UseVisualStyleBackColor = true;
            this.chkWatchFolder_SubFolders.CheckedChanged += new System.EventHandler(this.chkWatchFolder_SubFolders_CheckedChanged);
            // 
            // lblOneDriveFolder
            // 
            this.lblOneDriveFolder.AutoSize = true;
            this.lblOneDriveFolder.Location = new System.Drawing.Point(20, 90);
            this.lblOneDriveFolder.Name = "lblOneDriveFolder";
            this.lblOneDriveFolder.Size = new System.Drawing.Size(122, 20);
            this.lblOneDriveFolder.TabIndex = 1;
            this.lblOneDriveFolder.Text = "OneDriver Folder";
            this.lblOneDriveFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOneDriveFolder
            // 
            this.txtOneDriveFolder.Location = new System.Drawing.Point(144, 87);
            this.txtOneDriveFolder.Multiline = true;
            this.txtOneDriveFolder.Name = "txtOneDriveFolder";
            this.txtOneDriveFolder.Size = new System.Drawing.Size(301, 26);
            this.txtOneDriveFolder.TabIndex = 3;
            this.txtOneDriveFolder.TextChanged += new System.EventHandler(this.txtOneDriveFolder_TextChanged);
            // 
            // btnOneDriveFolder
            // 
            this.btnOneDriveFolder.Location = new System.Drawing.Point(451, 86);
            this.btnOneDriveFolder.Name = "btnOneDriveFolder";
            this.btnOneDriveFolder.Size = new System.Drawing.Size(94, 29);
            this.btnOneDriveFolder.TabIndex = 4;
            this.btnOneDriveFolder.Text = "Browse";
            this.btnOneDriveFolder.UseVisualStyleBackColor = true;
            this.btnOneDriveFolder.Click += new System.EventHandler(this.btnOneDriveFolder_Click);
            // 
            // txtDelayUpdate
            // 
            this.txtDelayUpdate.Location = new System.Drawing.Point(144, 197);
            this.txtDelayUpdate.Name = "txtDelayUpdate";
            this.txtDelayUpdate.Size = new System.Drawing.Size(75, 27);
            this.txtDelayUpdate.TabIndex = 5;
            this.txtDelayUpdate.TextChanged += new System.EventHandler(this.txtDelay_TextChanged);
            // 
            // lblDelayUpdate
            // 
            this.lblDelayUpdate.AutoSize = true;
            this.lblDelayUpdate.Location = new System.Drawing.Point(39, 200);
            this.lblDelayUpdate.Name = "lblDelayUpdate";
            this.lblDelayUpdate.Size = new System.Drawing.Size(103, 20);
            this.lblDelayUpdate.TabIndex = 5;
            this.lblDelayUpdate.Text = "Delay Update:";
            this.lblDelayUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDelayOverride
            // 
            this.txtDelayOverride.Location = new System.Drawing.Point(144, 252);
            this.txtDelayOverride.Name = "txtDelayOverride";
            this.txtDelayOverride.Size = new System.Drawing.Size(75, 27);
            this.txtDelayOverride.TabIndex = 6;
            this.txtDelayOverride.TextChanged += new System.EventHandler(this.txtMasterDelay_TextChanged);
            // 
            // lblDelayOverride
            // 
            this.lblDelayOverride.AutoSize = true;
            this.lblDelayOverride.Location = new System.Drawing.Point(31, 256);
            this.lblDelayOverride.Name = "lblDelayOverride";
            this.lblDelayOverride.Size = new System.Drawing.Size(111, 20);
            this.lblDelayOverride.TabIndex = 5;
            this.lblDelayOverride.Text = "Delay Override:";
            this.lblDelayOverride.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barUpdateAfter
            // 
            this.barUpdateAfter.Location = new System.Drawing.Point(549, 200);
            this.barUpdateAfter.Name = "barUpdateAfter";
            this.barUpdateAfter.Size = new System.Drawing.Size(125, 29);
            this.barUpdateAfter.TabIndex = 7;
            // 
            // barMaster
            // 
            this.barMaster.Location = new System.Drawing.Point(549, 246);
            this.barMaster.Name = "barMaster";
            this.barMaster.Size = new System.Drawing.Size(125, 29);
            this.barMaster.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(187, 389);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(337, 389);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnKick
            // 
            this.btnKick.Location = new System.Drawing.Point(487, 389);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(94, 29);
            this.btnKick.TabIndex = 9;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(144, 300);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(535, 71);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMessage.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Event);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Event);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Event);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCopyright.Location = new System.Drawing.Point(697, 428);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(91, 13);
            this.lblCopyright.TabIndex = 11;
            this.lblCopyright.Text = "By Mark Ross";
            // 
            // lblDelayUpdateDescp
            // 
            this.lblDelayUpdateDescp.AutoSize = true;
            this.lblDelayUpdateDescp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDelayUpdateDescp.Location = new System.Drawing.Point(225, 200);
            this.lblDelayUpdateDescp.Name = "lblDelayUpdateDescp";
            this.lblDelayUpdateDescp.Size = new System.Drawing.Size(262, 20);
            this.lblDelayUpdateDescp.TabIndex = 12;
            this.lblDelayUpdateDescp.Text = "Wait this long after a detected change";
            // 
            // lblDelayOverrideDescp
            // 
            this.lblDelayOverrideDescp.AutoSize = true;
            this.lblDelayOverrideDescp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDelayOverrideDescp.Location = new System.Drawing.Point(225, 255);
            this.lblDelayOverrideDescp.Name = "lblDelayOverrideDescp";
            this.lblDelayOverrideDescp.Size = new System.Drawing.Size(176, 20);
            this.lblDelayOverrideDescp.TabIndex = 13;
            this.lblDelayOverrideDescp.Text = "Alway Kick after this time";
            // 
            // frmOneDriveKicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDelayOverrideDescp);
            this.Controls.Add(this.lblDelayUpdateDescp);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnKick);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.barMaster);
            this.Controls.Add(this.barUpdateAfter);
            this.Controls.Add(this.lblDelayOverride);
            this.Controls.Add(this.lblDelayUpdate);
            this.Controls.Add(this.txtDelayOverride);
            this.Controls.Add(this.txtDelayUpdate);
            this.Controls.Add(this.chkWatchFolder_SubFolders);
            this.Controls.Add(this.btnOneDriveFolder);
            this.Controls.Add(this.btnWatchFolder);
            this.Controls.Add(this.lblOneDriveFolder);
            this.Controls.Add(this.lblWatchFolder);
            this.Controls.Add(this.txtOneDriveFolder);
            this.Controls.Add(this.txtWatchFolder);
            this.Name = "frmOneDriveKicker";
            this.Text = "OneDrive Kicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private Label lblWatchFolder;
        private TextBox txtWatchFolder;
        private Button btnWatchFolder;
        private CheckBox chkWatchFolder_SubFolders;
        private Label lblOneDriveFolder;
        private TextBox txtOneDriveFolder;
        private Button btnOneDriveFolder;
        private FolderBrowserDialog folderBrowserDialog;
        private TextBox txtDelayUpdate;
        private Label lblDelayUpdate;
        private TextBox txtDelayOverride;
        private Label lblDelayOverride;
        private ProgressBar barUpdateAfter;
        private ProgressBar barMaster;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Button btnStop;
        private Button btnKick;
        private TextBox txtMessage;
        private FileSystemWatcher fileSystemWatcher1;
        private Label lblCopyright;
        private Label lblDelayOverrideDescp;
        private Label lblDelayUpdateDescp;
    }  //class
}  //namespace