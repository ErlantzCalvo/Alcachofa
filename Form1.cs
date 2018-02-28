using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;


namespace Alcachofa
{
    public partial class Alcachofa : Form
    {
        string folderName="";
        

        public Alcachofa()
        {
            InitializeComponent();

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolder = Path.Combine(folder, "Alcachofolder");
            if (!Directory.Exists(specificFolder))
                Directory.CreateDirectory(specificFolder);

            if (File.Exists(Path.Combine(specificFolder,"Directorio.txt")))
            {
                StreamReader sr = new StreamReader(Path.Combine(specificFolder, "Directorio.txt"));
                folderName = sr.ReadLine();
                sr.Close();
                sr.Dispose();
            }
            else
            {
                folderName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamWriter sw = new StreamWriter(Path.Combine(specificFolder, "Directorio.txt"));
                sw.Write(folderName);
                sw.Close();
                
            }

            
            this.ContextMenuStrip = cmTwitter;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(folder, "Alcachofolder");
                folderName = folderBrowserDialog1.SelectedPath;
                StreamWriter sw = new StreamWriter(Path.Combine(specificFolder, "Directorio.txt"));
                sw.Write(folderName);
                sw.Flush();
                sw.Close();
                
            }   

        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtEnlace.Text))
            {
                
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = false;
                    }

                }
                this.lblProgreso.Visible = true;
                this.pbProgreso.Visible = true;
                bgwVideo.RunWorkerAsync();
            }
            else {
                MessageBox.Show("Si insertas un enlace, mejor.");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtEnlace.Text))
            {
                
                this.lblProgreso.Visible = true;
                this.pbProgreso.Visible = true;
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = false;
                    }

                }

                backgroundWorker1.RunWorkerAsync();
                

                }
            else
            {
                MessageBox.Show("Si insertas un enlace, mejor.");
            }
        }

         

        
      

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs evt)
        {


            try
            {
                var backgroundWorker = sender as BackgroundWorker;
                backgroundWorker1.ReportProgress(10);

                YouTube youtube = YouTube.Default;
                var vid = youtube.GetAllVideos(this.txtEnlace.Text);
                var audio = vid
                    .Where(e => e.AudioFormat == AudioFormat.Aac && e.AdaptiveKind == AdaptiveKind.Audio)
                    .ToList();
                if (audio.Count > 0)
                {
                    backgroundWorker1.ReportProgress(10);
                    System.IO.File.WriteAllBytes(Path.Combine(folderName, audio[0].FullName), audio[0].GetBytes());

                    backgroundWorker1.ReportProgress(30);

                    var inputFile = new MediaFile { Filename = Path.Combine(folderName, audio[0].FullName) };
                    var outputFile = new MediaFile { Filename = $"{Path.Combine(folderName, audio[0].Title)}.mp3" };

                    backgroundWorker1.ReportProgress(20);

                    using (var engine = new Engine())
                    {
                        backgroundWorker1.ReportProgress(10);
                        engine.Convert(inputFile, outputFile);
                        backgroundWorker1.ReportProgress(10);
                    }
                    File.Delete(Path.Combine(folderName, audio[0].FullName));
                    backgroundWorker1.ReportProgress(10);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "No se puede descargar el audio.\nComprueba el enlace."); 
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgreso.Value += e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
                
            }
            this.lblProgreso.Visible = false;
            this.pbProgreso.Visible = false;
            this.pbProgreso.Value = 0;
           
            System.GC.Collect();
        }

        private void bgwVideo_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                var backgroundWorker = sender as BackgroundWorker;
                bgwVideo.ReportProgress(20);
                var youTube = YouTube.Default;
                bgwVideo.ReportProgress(20);
                Uri link = new Uri(this.txtEnlace.Text);
                var video = youTube.GetVideo(this.txtEnlace.Text);
                File.WriteAllBytes(Path.Combine(folderName, video.FullName), video.GetBytes());
                       
                    
                   
                bgwVideo.ReportProgress(40);
                File.WriteAllBytes(Path.Combine(folderName, video.FullName), video.GetBytes());
                bgwVideo.ReportProgress(20);
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(this,"No se puede descargar el vídeo.\nComprueba el enlace.");               
            }
        }

        private void bgwVideo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgreso.Value += e.ProgressPercentage;
        }

        private void bgwVideo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
               
            }
            this.lblProgreso.Visible = false;
            this.pbProgreso.Visible = false;
            this.pbProgreso.Value = 0;
            
            System.GC.Collect();
        }

        private void twitterDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/erlantzcalvo");
        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
