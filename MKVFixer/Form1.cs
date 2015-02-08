using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
using System.Reflection;

namespace MKVFixer
{
    public partial class Form1 : Form
    {
        private Process proc;

 
        private bool Abort = false;
        private int filesUnprocessed;
        private int totalFiles;


        private string PathToApp = AppDomain.CurrentDomain.BaseDirectory;
        private string AppName = Assembly.GetExecutingAssembly().GetName().Name;

        private enum conftypes
        {
            isstring,
            isbool
        };

        private string getAppSetting(string key, conftypes conftypes)
        {
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = @PathToApp + AppName + ".config";
            var configFile = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            if (settings[key] == null)
            {
                if (conftypes == conftypes.isstring)
                    settings.Add(key, string.Empty);
                else
                    settings.Add(key, "true");
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                if (conftypes == conftypes.isstring)
                    return string.Empty;
                else
                    return "true";
            }
            else
            {
                return settings[key].Value;
            }            
        }

        private void setAppSetting(string key, string value)
        {
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = @PathToApp + AppName + ".config";
            var configFile = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
                settings.Add(key, value);
            else
                settings[key].Value = value;                
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);               
        }        

        public Form1()
        {
            InitializeComponent();

            // Set windows titel
            this.Text = Assembly.GetExecutingAssembly().GetName().Name + " V" + Assembly.GetExecutingAssembly().GetName().Version;
            
            // Path to mkWDClean
            this.tbPathTomkWDClean.Text = getAppSetting("PathTomkWDClean", conftypes.isstring);
           
            // Path to medias
            this.tbStartDir.Text = getAppSetting("StartDir", conftypes.isstring);
            
            // Do backup's?
            this.cbMakeBackup.Checked = Convert.ToBoolean(getAppSetting("MakeBackup", conftypes.isbool));

            // Show_mkWDCleanConsole?
            this.cbShow_mkWDCleanConsole.Checked = Convert.ToBoolean(getAppSetting("Show_mkWDCleanConsole", conftypes.isbool));

            // Linklabel to MKVToolNix
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.bunkus.org/videotools/mkvtoolnix/downloads.html#windows";
            linkLabel1.Links.Add(link);

            // Linklabel to mkWDClean
            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "https://sourceforge.net/projects/matroska/files/mkclean/mkclean-win32.v0.8.7.zip/download";
            linkLabel2.Links.Add(link2);            
        }

        /// <summary>
        /// Path to mkWDClean
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPathTomkWDClean_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Filter = ("mkWDClean|mkWDClean.exe");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbPathTomkWDClean.Text = this.openFileDialog1.FileName;
            }
        }

        private void btnStartDir_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tbStartDir.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// Scan the filesystem for mkv's that hasn't been optimized
        /// </summary>
        private void ScanFileSystem()
        {
            filesUnprocessed = 0;
            this.statusStrip.TabIndex = 0;
            this.lvMovies.Items.Clear();
            this.statuslbl.Text = "Please wait....Scanning filesystem";

            this.lvMovies.SmallImageList = this.imageList1;


            this.statusStrip.Refresh();

            Cursor.Current = Cursors.WaitCursor;
            string[] files = Directory.GetFiles(this.tbStartDir.Text, "*.mkv", SearchOption.AllDirectories);
            
            foreach (string file in files)
            {
                ListViewItem movie = new ListViewItem();
                if (System.IO.File.Exists(file + ".mkvfixed"))
             
                {               
                    movie.ImageIndex = 0;
                }
                else
                {
                    filesUnprocessed += 1;
                    movie.ImageIndex = 1;
                }                
                movie.Text = (Path.GetFileNameWithoutExtension(file));
                movie.SubItems.Add(Path.GetDirectoryName(file));
                this.lvMovies.Items.Add(movie);
            }


            totalFiles = files.Length;

            this.statuslbl.Text = "Found " + totalFiles.ToString() + " files : Unprocessed are : " + filesUnprocessed.ToString();
            statusFileofFile.Text = "";
            Cursor.Current = Cursors.Default;
        }

        static void CaptureOutput(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data, ConsoleColor.Green);
        }


        /// <summary>
        /// Fix the actual file
        /// </summary>
        /// <param name="file"></param>
        /// <param name="Index"></param>
        private bool FixFile(string file, int Index)
        {
            this.statuslbl.Text = "Working";           
       
            Cursor.Current = Cursors.WaitCursor;
            string param = "--optimize \"" + file + "\" \"" + file + ".clean\"";
            int i;
            // Process information
            ProcessStartInfo startInfo = new ProcessStartInfo();
            // Show or hide            
            startInfo.FileName = this.tbPathTomkWDClean.Text;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = false;
            startInfo.CreateNoWindow = !cbShow_mkWDCleanConsole.Checked;
            startInfo.Arguments = param;                
            using (proc = Process.Start(startInfo))
            {
                Cursor.Current = Cursors.WaitCursor;               
                proc.WaitForExit();
                // can also now look at proc.ExitCode
                i = proc.ExitCode;
            }

            if (i == 0)
            {
                // All went well
                if (this.cbMakeBackup.Checked)
                { 
                    if (System.IO.File.Exists(file + ".org")) System.IO.File.Delete(file + ".org");
                    System.IO.File.Move(file, file + ".org");
                    System.IO.File.Move(file + ".clean", file);
                }
                else
                {
                    System.IO.File.Delete(file);
                    System.IO.File.Move(file + ".clean", file);
                }
                // Create the check file. 
                File.WriteAllText(file + ".mkvfixed", "Check file for " + Application.ProductName + "....Do not delete!");

                Cursor.Current = Cursors.Default;
                this.statuslbl.Text = "Ready";
                return true;             
            }
            else
            {
                // Something went wrong here
                // Cleanup temp files
                if (System.IO.File.Exists(file + ".clean")) System.IO.File.Delete(file + ".clean");
                Cursor.Current = Cursors.Default;
                this.statuslbl.Text = "Ready";
                return false;
            }                       
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (this.btnFix.Text == "&Run")
            {
                this.btnFix.Text = "&Stop";
                this.btnScan.Enabled = false;
                int count = 1;
                foreach (ListViewItem item in lvMovies.Items)
                {                   
                    this.lblProgress.Text = "Processing file: " + count.ToString() + " of " + filesUnprocessed.ToString();
                    this.statusStrip.Refresh();

                    if (item.ImageIndex != 0)
                    {                                  
                        ThreadParams threadparams = new ThreadParams
                        {
                            file = item.SubItems[1].Text + "\\" + item.Text + ".mkv",
                            index = item.Index                        
                        };
                        Cursor.Current = Cursors.WaitCursor;                    
                        lvMovies.Items[item.Index].ImageIndex = 3;
                        this.lvMovies.Refresh();   
                        // Start background job
                        this.backgroundWorker1.RunWorkerAsync(threadparams);
                        while (this.backgroundWorker1.IsBusy)
                        {                      
                            // Keep UI messages moving, so the form remains  
                            // responsive during the asynchronous operation.
                            Cursor.Current = Cursors.WaitCursor;     
                            Application.DoEvents();                            
                        }
                        this.lvMovies.Refresh();
                        Cursor.Current = Cursors.Default;
                        count++;
                    }
                    if (Abort)
                    {
                        this.btnFix.Text = "&Run";
                        this.btnScan.Enabled = true;
                        this.lblProgress.Text = "";
                        Abort = false;
                        break;
                    }                    
                }
                this.btnFix.Text = "&Run";
                this.btnScan.Enabled = true;
                this.lblProgress.Text = "";
            }
            else
            {
                // We need to cancel the running job
                this.backgroundWorker1.CancelAsync();
                Abort = true;
                proc.Kill();
                this.btnScan.Enabled = true;                
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            this.ScanFileSystem();
            this.btnFix.Enabled = (this.lvMovies.Items.Count > 0);
        }

        
        /// <summary>
        /// Check the outcome of the background thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // We got an error                
                int i = Convert.ToInt16(e.Error.Message.ToString());
                this.lvMovies.Items[i].ImageIndex = 2;               
            }
            else
            {
                // All went well
                int i = System.Convert.ToInt16(e.Result.ToString());
                this.lvMovies.Items[i].ImageIndex = 0;
            }
        }  
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            ThreadParams threadparams = e.Argument as ThreadParams;
            int index = threadparams.index;
            string file = threadparams.file;
            if (FixFile(file, index))
                e.Result = index;               
            else
                throw new Exception(index.ToString());                
        }

        private void tbStartDir_TextChanged(object sender, EventArgs e)
        {
            this.setAppSetting("StartDir", this.tbStartDir.Text);
            this.lvMovies.Items.Clear();
            this.statuslbl.Text = "Ready";
        }

        private void tbPathTomkWDClean_TextChanged(object sender, EventArgs e)
        {
            this.setAppSetting("PathTomkWDClean", this.tbPathTomkWDClean.Text);
        }

        private void cbMakeBackup_CheckStateChanged(object sender, EventArgs e)
        {
            this.setAppSetting("MakeBackup", this.cbMakeBackup.Checked.ToString());
        }

        private void cbShow_mkWDCleanConsole_CheckStateChanged(object sender, EventArgs e)
        {
            this.setAppSetting("Show_mkWDCleanConsole", this.cbShow_mkWDCleanConsole.Checked.ToString());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }
    }

    /// <summary>
    /// Parameters for the thread execution
    /// </summary>
    class ThreadParams
    {
        public string file { get; set; }
        public int index { get; set; }
    }


}
