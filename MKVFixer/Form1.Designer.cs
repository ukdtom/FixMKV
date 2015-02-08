namespace MKVFixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbStart = new System.Windows.Forms.TabPage();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.lvMovies = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tpSetup = new System.Windows.Forms.TabPage();
            this.cbShow_mkWDCleanConsole = new System.Windows.Forms.CheckBox();
            this.cbMakeBackup = new System.Windows.Forms.CheckBox();
            this.tbStartDir = new System.Windows.Forms.TextBox();
            this.lblStartDir = new System.Windows.Forms.Label();
            this.btnStartDir = new System.Windows.Forms.Button();
            this.btnPathTomkWDClean = new System.Windows.Forms.Button();
            this.lblPathTomkWDClean = new System.Windows.Forms.Label();
            this.tbPathTomkWDClean = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileofFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tbStart.SuspendLayout();
            this.tpSetup.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Select mkWDClean";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbStart);
            this.tabControl1.Controls.Add(this.tpSetup);
            this.tabControl1.Location = new System.Drawing.Point(0, -5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 542);
            this.tabControl1.TabIndex = 3;
            // 
            // tbStart
            // 
            this.tbStart.Controls.Add(this.btnScan);
            this.tbStart.Controls.Add(this.btnFix);
            this.tbStart.Controls.Add(this.lvMovies);
            this.tbStart.Location = new System.Drawing.Point(4, 22);
            this.tbStart.Name = "tbStart";
            this.tbStart.Padding = new System.Windows.Forms.Padding(3);
            this.tbStart.Size = new System.Drawing.Size(776, 516);
            this.tbStart.TabIndex = 0;
            this.tbStart.Text = "Start";
            this.tbStart.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(240, 473);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "S&can";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnFix
            // 
            this.btnFix.Enabled = false;
            this.btnFix.Location = new System.Drawing.Point(365, 473);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "&Run";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // lvMovies
            // 
            this.lvMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvMovies.GridLines = true;
            this.lvMovies.Location = new System.Drawing.Point(8, 6);
            this.lvMovies.Name = "lvMovies";
            this.lvMovies.Size = new System.Drawing.Size(760, 461);
            this.lvMovies.SmallImageList = this.imageList1;
            this.lvMovies.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMovies.TabIndex = 0;
            this.lvMovies.UseCompatibleStateImageBehavior = false;
            this.lvMovies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 324;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 463;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "done.png");
            this.imageList1.Images.SetKeyName(1, "missing.png");
            this.imageList1.Images.SetKeyName(2, "error.png");
            this.imageList1.Images.SetKeyName(3, "working.png");
            // 
            // tpSetup
            // 
            this.tpSetup.Controls.Add(this.linkLabel2);
            this.tpSetup.Controls.Add(this.linkLabel1);
            this.tpSetup.Controls.Add(this.cbShow_mkWDCleanConsole);
            this.tpSetup.Controls.Add(this.cbMakeBackup);
            this.tpSetup.Controls.Add(this.tbStartDir);
            this.tpSetup.Controls.Add(this.lblStartDir);
            this.tpSetup.Controls.Add(this.btnStartDir);
            this.tpSetup.Controls.Add(this.btnPathTomkWDClean);
            this.tpSetup.Controls.Add(this.lblPathTomkWDClean);
            this.tpSetup.Controls.Add(this.tbPathTomkWDClean);
            this.tpSetup.Location = new System.Drawing.Point(4, 22);
            this.tpSetup.Name = "tpSetup";
            this.tpSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetup.Size = new System.Drawing.Size(776, 516);
            this.tpSetup.TabIndex = 1;
            this.tpSetup.Text = "Setup";
            this.tpSetup.UseVisualStyleBackColor = true;
            // 
            // cbShow_mkWDCleanConsole
            // 
            this.cbShow_mkWDCleanConsole.AutoSize = true;
            this.cbShow_mkWDCleanConsole.Checked = true;
            this.cbShow_mkWDCleanConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShow_mkWDCleanConsole.Location = new System.Drawing.Point(209, 205);
            this.cbShow_mkWDCleanConsole.Name = "cbShow_mkWDCleanConsole";
            this.cbShow_mkWDCleanConsole.Size = new System.Drawing.Size(157, 17);
            this.cbShow_mkWDCleanConsole.TabIndex = 10;
            this.cbShow_mkWDCleanConsole.Text = "Show mkWDClean Console";
            this.cbShow_mkWDCleanConsole.UseVisualStyleBackColor = true;
            this.cbShow_mkWDCleanConsole.CheckStateChanged += new System.EventHandler(this.cbShow_mkWDCleanConsole_CheckStateChanged);
            // 
            // cbMakeBackup
            // 
            this.cbMakeBackup.AutoSize = true;
            this.cbMakeBackup.Checked = true;
            this.cbMakeBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMakeBackup.Location = new System.Drawing.Point(98, 205);
            this.cbMakeBackup.Name = "cbMakeBackup";
            this.cbMakeBackup.Size = new System.Drawing.Size(93, 17);
            this.cbMakeBackup.TabIndex = 9;
            this.cbMakeBackup.Text = "Make &Backup";
            this.cbMakeBackup.UseVisualStyleBackColor = true;
            this.cbMakeBackup.CheckStateChanged += new System.EventHandler(this.cbMakeBackup_CheckStateChanged);
            // 
            // tbStartDir
            // 
            this.tbStartDir.Location = new System.Drawing.Point(11, 114);
            this.tbStartDir.Name = "tbStartDir";
            this.tbStartDir.Size = new System.Drawing.Size(561, 20);
            this.tbStartDir.TabIndex = 8;
            this.tbStartDir.TextChanged += new System.EventHandler(this.tbStartDir_TextChanged);
            // 
            // lblStartDir
            // 
            this.lblStartDir.AutoSize = true;
            this.lblStartDir.Location = new System.Drawing.Point(8, 98);
            this.lblStartDir.Name = "lblStartDir";
            this.lblStartDir.Size = new System.Drawing.Size(72, 13);
            this.lblStartDir.TabIndex = 7;
            this.lblStartDir.Text = "Start directory";
            // 
            // btnStartDir
            // 
            this.btnStartDir.Location = new System.Drawing.Point(595, 114);
            this.btnStartDir.Name = "btnStartDir";
            this.btnStartDir.Size = new System.Drawing.Size(75, 23);
            this.btnStartDir.TabIndex = 6;
            this.btnStartDir.Text = "Start &Dir";
            this.btnStartDir.UseVisualStyleBackColor = true;
            this.btnStartDir.Click += new System.EventHandler(this.btnStartDir_Click);
            // 
            // btnPathTomkWDClean
            // 
            this.btnPathTomkWDClean.Location = new System.Drawing.Point(595, 19);
            this.btnPathTomkWDClean.Name = "btnPathTomkWDClean";
            this.btnPathTomkWDClean.Size = new System.Drawing.Size(75, 23);
            this.btnPathTomkWDClean.TabIndex = 5;
            this.btnPathTomkWDClean.Text = "&Locate";
            this.btnPathTomkWDClean.UseVisualStyleBackColor = true;
            this.btnPathTomkWDClean.Click += new System.EventHandler(this.btnPathTomkWDClean_Click);
            // 
            // lblPathTomkWDClean
            // 
            this.lblPathTomkWDClean.AutoSize = true;
            this.lblPathTomkWDClean.Location = new System.Drawing.Point(6, 3);
            this.lblPathTomkWDClean.Name = "lblPathTomkWDClean";
            this.lblPathTomkWDClean.Size = new System.Drawing.Size(104, 13);
            this.lblPathTomkWDClean.TabIndex = 4;
            this.lblPathTomkWDClean.Text = "Path to mkWDClean";
            // 
            // tbPathTomkWDClean
            // 
            this.tbPathTomkWDClean.Location = new System.Drawing.Point(9, 19);
            this.tbPathTomkWDClean.Name = "tbPathTomkWDClean";
            this.tbPathTomkWDClean.Size = new System.Drawing.Size(563, 20);
            this.tbPathTomkWDClean.TabIndex = 3;
            this.tbPathTomkWDClean.TextChanged += new System.EventHandler(this.tbPathTomkWDClean_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl,
            this.toolStripStatusLabel1,
            this.statusFileofFile,
            this.lblProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(784, 24);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(43, 19);
            this.statuslbl.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(726, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusFileofFile
            // 
            this.statusFileofFile.Name = "statusFileofFile";
            this.statusFileofFile.Size = new System.Drawing.Size(0, 19);
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 19);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select root directory to scan";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 53);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get MKVToolNix";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(119, 53);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Get mkWDClean";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbStart.ResumeLayout(false);
            this.tpSetup.ResumeLayout(false);
            this.tpSetup.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbStart;
        private System.Windows.Forms.TabPage tpSetup;
        private System.Windows.Forms.Button btnPathTomkWDClean;
        private System.Windows.Forms.Label lblPathTomkWDClean;
        private System.Windows.Forms.TextBox tbPathTomkWDClean;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox tbStartDir;
        private System.Windows.Forms.Label lblStartDir;
        private System.Windows.Forms.Button btnStartDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.ListView lvMovies;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.ToolStripStatusLabel statusFileofFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox cbMakeBackup;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.CheckBox cbShow_mkWDCleanConsole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

