using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VideoLibrary;
using Newtonsoft.Json;
using System.Net;
using System.Threading;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace Alcachofa
{
    public partial class Alcachofa : Form
    {
        string folderName = "";
        string language = "";
        const String apiKey = "PUT_HERE_YOUR_API_KEY"; //Your Youtube Api Key
        string videoTitle;
        ResourceManager res;
        CultureInfo cultureInfo;

        public Alcachofa()
        {
            InitializeComponent();

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolder = Path.Combine(folder, "Alcachofolder");
            if (!Directory.Exists(specificFolder))
            {
                Directory.CreateDirectory(specificFolder);

                folderName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                language = "es";
                this.espanolToolStripMenuItem.Checked = true;
                StreamWriter sw = new StreamWriter(Path.Combine(specificFolder, "Directorio.txt"));
                sw.WriteLine(folderName);
                sw.WriteLine(language);
                sw.Close();
            }

            else if (File.Exists(Path.Combine(specificFolder, "Directorio.txt")))
            {
                string[] sr = File.ReadAllLines(Path.Combine(specificFolder, "Directorio.txt"));
                folderName = sr[0];
                res = (sr[1].Equals("en")) ? Properties.Resource.en_US.ResourceManager : Properties.Resource.es_ES.ResourceManager;
                ChangeLanguageAtStart(res.GetString(sr[1]));
            }
            else {
                folderName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                language = "es";
                this.espanolToolStripMenuItem.Checked = true;
                StreamWriter sw = new StreamWriter(Path.Combine(specificFolder, "Directorio.txt"));
                sw.WriteLine(folderName);
                sw.WriteLine(language);
                sw.Close();
            }
            


            this.ContextMenuStrip = cmGeneral;
        }

        private void SwitchLanguages()
        {
            
           
            this.btnVideo.Text = res.GetString("video_button", cultureInfo);
            this.button2.Text = res.GetString("audio_button", cultureInfo);
            this.button3.Text = res.GetString("save_button", cultureInfo);
            this.btnCancelPlaylist.Text = res.GetString("cancel_button", cultureInfo);
            this.lblProgress.Text = res.GetString("ProgressBar", cultureInfo);
            this.lblLink.Text = res.GetString("youtube_link", cultureInfo);
            this.fileToolStripMenuItem.Text = res.GetString("file_menu", cultureInfo);
            this.audioToolStripMenuItem.Text = res.GetString("audio_menu", cultureInfo);
            this.aboutToolStripMenuItem.Text = res.GetString("about_menu", cultureInfo);
            this.saveInToolStripMenuItem.Text = res.GetString("save_in_menu", cultureInfo);
            this.exitToolStripMenuItem.Text = res.GetString("exit_menu", cultureInfo);
            this.betterAudioQualityToolStripMenuItem.Text = res.GetString("better_audio_quality_menu", cultureInfo);
            this.developersTwitterToolStripMenuItem.Text = res.GetString("developers_twitter_menu", cultureInfo);
            this.betterAudioQualityToolStripMenuItem.ToolTipText = res.GetString("better_audio_tool_tip", cultureInfo);
            this.espanolToolStripMenuItem.Text = res.GetString("spanish_language_menu", cultureInfo);
            this.inglesToolStripMenuItem.Text = res.GetString("english_language_menu", cultureInfo);
            this.idiomaToolStripMenuItem.Text = res.GetString("languages_menu", cultureInfo);
            this.developersTwitterToolStripMenuItem1.Text = res.GetString("developers_twitter_menu", cultureInfo);
            this.applicationCloseToolStripMenuItem.Text = res.GetString("close_application", cultureInfo);

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
            if (!string.IsNullOrEmpty(this.txtLink.Text))
            {
                if (IsPlayList(this.txtLink.Text))
                {
                    if (MessageBox.Show("El enlace corresponde a una lista de reproducción, ¿desea descargar todo el contenido de la lista?", "Descargar todo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        DownloadPlaylist(bgwVideo);
                    }

                }
                else
                {
                    SetUpControlsForDownload();
                    bgwVideo.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Inserte un enlace de YouTube en el cuadro de texto.");
            }
        }

        private void DownloadPlaylist(BackgroundWorker bgw)
        {
            //https://www.youtube.com/watch?v=Q6yuB-CzbsM&list=RDEMxNTNC6JgJmZ6WY_MrB4LYw&start_radio=1
            
            string[] listParams = this.txtLink.Text.Split('&');
            string listId = Array.Find(listParams, p => p.Contains("list"));
            listId = listId.Split('=')[1];
            string json = string.Empty;
            string url = "https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=50&playlistId=" + listId + "&key=" + apiKey;
            using (WebClient wc = new WebClient())
            {
                try
                {
                    json = wc.DownloadString(url);
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("403"))
                    {
                        MessageBox.Show("Error al descargar playlist. Compruebe que la lista sea pública (si la lista la ha creado usted puede establecerla como pública en los ajustes de la lista).");

                    }
                    else
                    {
                        MessageBox.Show("Enlace no válido, por favor, compruebe el enlace.");
                    }
                    return;
                }

            }

            dynamic videos = JsonConvert.DeserializeObject<dynamic>(json);
            this.btnCancelPlaylist.Visible = true;
            foreach (var item in videos.items)
            {
                SetUpControlsForDownload();

                String actualVideoUrl = "https://www.youtube.com/watch?v=" + item.snippet.resourceId.videoId;
                this.txtLink.Text = actualVideoUrl;


                bgw.RunWorkerAsync();


                while (bgw.IsBusy && !bgw.CancellationPending)
                {
                    Application.DoEvents();
                }
                if (bgw.CancellationPending)
                {
                    this.btnCancelPlaylist.Visible = false;
                    this.btnCancelPlaylist.Text = "Cancelar descarga";
                    return;
                }



            }
            this.btnCancelPlaylist.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtLink.Text))
            {
                if (!IsPlayList(this.txtLink.Text))
                {


                    SetUpControlsForDownload();

                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    if (MessageBox.Show("El enlace corresponde a una lista de reproducción, ¿desea descargar todo el contenido de la lista?", "Descargar todo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        DownloadPlaylist(backgroundWorker1);
                    }

                }

            }
            else
            {
                MessageBox.Show("Inserte un enlace de YouTube en el cuadro de texto.");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs evt)
        {


            try
            {

                YouTube youtube = YouTube.Default;
                var backgroundWorker = sender as BackgroundWorker;
                backgroundWorker1.ReportProgress(10);


                if (betterAudioQualityToolStripMenuItem.Checked)
                {
                    var vid = youtube.GetAllVideos(this.txtLink.Text);
                    var audio = vid
                        .Where(e => e.AudioFormat == AudioFormat.Aac && e.AdaptiveKind == AdaptiveKind.Audio)
                        .ToList();
                    this.videoTitle = audio[0].Title;
                    if (audio.Count > 0)
                    {
                        backgroundWorker1.ReportProgress(10);
                        System.IO.File.WriteAllBytes(Path.Combine(folderName, audio[0].FullName), audio[0].GetBytes());

                        backgroundWorker1.ReportProgress(30);


                        var inputFile = new MediaFile { Filename = Path.Combine(folderName, audio[0].FullName) };
                        var outputFile = new MediaFile { Filename = $"{Path.Combine(folderName, audio[0].FullName)}.mp3" };

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
                else
                {
                    YouTubeVideo audio = youtube.GetVideo(this.txtLink.Text);
                    this.videoTitle = audio.Title;
                    backgroundWorker1.ReportProgress(10);
                    File.WriteAllBytes(Path.Combine(folderName, audio.FullName), audio.GetBytes());
                    backgroundWorker1.ReportProgress(30);
                    var inputFile = new MediaFile { Filename = Path.Combine(folderName, audio.FullName) };
                    var outputFile = new MediaFile { Filename = $"{Path.Combine(folderName, audio.FullName)}.mp3" };
                    backgroundWorker1.ReportProgress(20);
                    using (var engine = new Engine())
                    {
                        backgroundWorker1.ReportProgress(10);
                        engine.Convert(inputFile, outputFile);
                        backgroundWorker1.ReportProgress(10);
                    }
                    File.Delete(Path.Combine(folderName, audio.FullName));
                    backgroundWorker1.ReportProgress(10);
                }
                if (backgroundWorker1.CancellationPending) evt.Cancel = true;

            }
            catch (ThreadAbortException ex) {

            }
            catch (Exception e)
            {

                this.Invoke((Func<DialogResult>)(() => MessageBox.Show(this, "No se puede descargar el vídeo.\nCompruebe el enlace.")));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgress.Value += e.ProgressPercentage;
            this.lblVideoTitle.Text = this.videoTitle;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FinishedButtonsSetUp();
        }

        private void bgwVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var backgroundWorker = sender as BackgroundWorker;
                bgwVideo.ReportProgress(20);
                var youTube = YouTube.Default;
                bgwVideo.ReportProgress(20);

                YouTubeVideo video = youTube.GetVideo(this.txtLink.Text);
                this.videoTitle = video.Title;
                File.WriteAllBytes(Path.Combine(folderName, video.FullName), video.GetBytes());



                bgwVideo.ReportProgress(40);
                File.WriteAllBytes(Path.Combine(folderName, video.FullName), video.GetBytes());
                bgwVideo.ReportProgress(20);

                if (bgwVideo.CancellationPending) e.Cancel = true;
            }
            catch (Exception ex)
            {
                this.Invoke((Func<DialogResult>)(() => MessageBox.Show(this, "No se puede descargar el vídeo.\nCompruebe el enlace.")));
            }


        }

        private void bgwVideo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgress.Value += e.ProgressPercentage;
            this.lblVideoTitle.Text = this.videoTitle;


        }

        private void bgwVideo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FinishedButtonsSetUp();

        }

        private void FinishedButtonsSetUp()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }

            }
            this.lblProgress.Visible = false;
            this.pbProgress.Visible = false;
            this.lblVideoTitle.Text = string.Empty;
            this.pbProgress.Value = 0;

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

        private bool IsPlayList(string url)
        {
            return url.Contains("list");
        }

        private void SetUpControlsForDownload()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name != this.btnCancelPlaylist.Name)
                {
                    c.Enabled = false;
                }

            }
            this.lblProgress.Visible = true;
            this.pbProgress.Visible = true;
            this.lblVideoTitle.Visible = true;

        }

        private void btnCancelPlaylist_Click(object sender, EventArgs e)
        {


            this.btnCancelPlaylist.Text = "Cancelando...";
            if (bgwVideo.IsBusy)
            {
                bgwVideo.CancelAsync();
            }
            else
            {
                backgroundWorker1.CancelAsync();
            }


        }

        private void mejorCalidadDeAudioToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (betterAudioQualityToolStripMenuItem.Checked) MessageBox.Show("Habilitar esta función puede generar tiempos de espera más altos de lo normal a la hora de descargar archivos de audio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void languageToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.espanolToolStripMenuItem.CheckedChanged -= this.languageToolStripMenuItem_CheckedChanged;
            this.inglesToolStripMenuItem.CheckedChanged -= this.languageToolStripMenuItem_CheckedChanged;

            if (this.inglesToolStripMenuItem != (ToolStripMenuItem)sender)
            {
                
                this.inglesToolStripMenuItem.Checked = false;
                this.espanolToolStripMenuItem.Checked = true;
            }
            else
            {
               
                this.inglesToolStripMenuItem.Checked = true;
                this.espanolToolStripMenuItem.Checked = false;
            }

            this.espanolToolStripMenuItem.CheckedChanged += this.languageToolStripMenuItem_CheckedChanged;
            this.inglesToolStripMenuItem.CheckedChanged += this.languageToolStripMenuItem_CheckedChanged;

            ChangeLanguageAtStart(sender.ToString());
        }

        private void ChangeLanguageAtStart(string lan)
        {
            string[] s = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Alcachofolder\\Directorio.txt");
            s[1] = (lan.Equals(res.GetString("spanish_language_menu", cultureInfo))) ? "es" : "en";
            res = (s[1].Equals("en")) ? Properties.Resource.en_US.ResourceManager : Properties.Resource.es_ES.ResourceManager;
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Alcachofolder\\Directorio.txt", s);
            SwitchLanguages();
        }
    }
}
