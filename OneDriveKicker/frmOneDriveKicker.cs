namespace OneDriveKicker
{
    public partial class frmOneDriveKicker : Form
    {


        bool kickerRunning = false;


        public frmOneDriveKicker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.ReadFile();
            this.Text = Settings.AppName;
            this.Update();

            txtWatchFolder.Text = Settings.WatchFolder;
            chkWatchFolder_SubFolders.Checked = Settings.WatchFolder_IncludeSubFolders;
            txtOneDriveFolder.Text = Settings.OneDriveFolder;

            txtDelayUpdate.Text = Settings.Delay.ToString();
            barUpdateAfter.Maximum = Settings.Delay;

            txtDelayOverride.Text = Settings.DelayOverride.ToString();
            barMaster.Maximum = Settings.DelayOverride;
        }



        #region#  System Tray  #

        /// <summary>
        /// System Tray
        /// </summary>
        private NotifyIcon notifyIcon;
        //Settings settings = new Settings();



        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }



        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon.Visible = true;
                this.Hide();
                e.Cancel = true;

                kickerRunning = true;
                timer1.Start();
            }
        }


        #endregion System Tray



        /// <summary>
        /// Folder Watch
        /// </summary>
        private void btnWatchFolder_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = folderBrowserDialog.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                txtWatchFolder.Text = folderBrowserDialog.SelectedPath;
                Settings.WatchFolder = folderBrowserDialog.SelectedPath;

                //  AutoHeight and move other controls down
                int WatchFolder_Height = txtWatchFolder.GetPositionFromCharIndex(txtWatchFolder.Text.Length - 1).Y + 3 + txtWatchFolder.Font.Height;
                if (WatchFolder_Height > 85) { WatchFolder_Height = 85; }
                txtWatchFolder.Height = WatchFolder_Height;
                lblOneDriveFolder.Top = WatchFolder_Height + 87 - 24;  //from line:105 & line-70 - 4
                txtOneDriveFolder.Top = WatchFolder_Height + 87 - 24;  //as above
                btnOneDriveFolder.Top = WatchFolder_Height + 87 - 24;  //as above
            }
        }



        private void txtWatchFolder_TextChanged(object sender, EventArgs e)
        {
            Settings.WatchFolder = txtWatchFolder.Text;
            Settings.WriteFile();
            txtMessage.Visible = false;

            try
            {
                fileSystemWatcher1.Path = txtWatchFolder.Text;
            }
            catch (Exception ex)
            {
                txtMessage.Text = "WatchFolder TextChanged:\r\n" + ex.Message;
                txtMessage.Visible = true;
                txtMessage.BackColor = Color.Yellow;
                txtMessage.ForeColor = Color.Red;
                txtWatchFolder.Focus();
            }

        }


        private void chkWatchFolder_SubFolders_CheckedChanged(object sender, EventArgs e)
        {
            Settings.WatchFolder_IncludeSubFolders = chkWatchFolder_SubFolders.Checked;
            Settings.WriteFile();
            fileSystemWatcher1.IncludeSubdirectories = chkWatchFolder_SubFolders.Checked;
        }


        private void txtOneDriveFolder_TextChanged(object sender, EventArgs e)
        {
            Settings.OneDriveFolder = txtOneDriveFolder.Text;
            Settings.WriteFile();
        }



        /// <summary>
        /// Folder OneDrive
        /// </summary>
        private void btnOneDriveFolder_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = folderBrowserDialog.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                txtOneDriveFolder.Text = folderBrowserDialog.SelectedPath;
                Settings.OneDriveFolder = folderBrowserDialog.SelectedPath;

                //  AutoHeight and move other controls down
                int OneDriveFolder_Height = txtWatchFolder.GetPositionFromCharIndex(txtOneDriveFolder.Text.Length - 1).Y + 3 + txtOneDriveFolder.Font.Height;
                if (OneDriveFolder_Height > 85) { OneDriveFolder_Height = 85; }
                txtWatchFolder.Height = OneDriveFolder_Height;
            }
        }



        private void txtDelay_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(txtDelayUpdate.Text, out Settings.Delay);
            Settings.WriteFile();
        }


        private void txtMasterDelay_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(txtDelayOverride.Text, out Settings.DelayOverride);
            Settings.WriteFile();
        }



        private void WriteFile()
        {
            if (txtOneDriveFolder.Text.Length > 0)
            {
                FileInfo fi = new FileInfo(txtOneDriveFolder.Text + "/OneDriveKicker.txt");
                StreamWriter sw = fi.CreateText();
                sw.WriteLine(System.DateTime.Now);
                sw.Close();
            }
        }



        #region Buttons

        private void btnStart_Click(object sender, EventArgs e)
        {
            kickerRunning = true;
            timer1.Start();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            kickerRunning = false;
            timer1.Stop();
        }


        private void btnKick_Click(object sender, EventArgs e)
        {
            Kick();
        }

        #endregion Buttons



        private void timer1_Tick(object sender, EventArgs e)
        {

            if (barUpdateAfter.Value == barUpdateAfter.Maximum || barMaster.Value == barMaster.Maximum)
            {
                Kick();
            }
            else
            {
                barUpdateAfter.Value ++;
                barMaster.Value ++;
            }

        }  // timer1_Tick



        void Kick()
        {
            WriteFile();
            timer1.Stop();
            barUpdateAfter.Value = 0;
            barMaster.Value = 0;
            txtMessage.Visible = false;
        }


        //  File Watcher
        private void fileSystemWatcher1_Event(object sender, FileSystemEventArgs e)
        {
            fileSystemWatcher1_Message(e.ChangeType.ToString(), e.FullPath);
        }


        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            fileSystemWatcher1_Message("Renamed", e.FullPath);
        }


        private void fileSystemWatcher1_Message(string head, string mesg)
        {
            timer1.Start();
            barUpdateAfter.Value = 0;

            txtMessage.Text = head + ":\r\n" + mesg;
            txtMessage.Visible = true;
            txtMessage.BackColor = Color.White;
            txtMessage.ForeColor = Color.Blue;
        }



    }  //class
}  //namespace