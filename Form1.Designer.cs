using System.Windows.Forms;

namespace Alcachofa
{
    partial class Alcachofa
    {
        
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alcachofa));
            this.lblLink = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bgwVideo = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnCancelPlaylist = new System.Windows.Forms.Button();
            this.cmGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.developersTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espanolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betterAudioQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersTwitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmGeneral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLink.Location = new System.Drawing.Point(15, 44);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(279, 32);
            this.lblLink.TabIndex = 0;
            this.lblLink.Text = "Enlace de YouTube :";
            // 
            // txtLink
            // 
            this.helpProvider1.SetHelpString(this.txtLink, "Pega aquí el enlace de un vídeo de YouTube.");
            this.txtLink.Location = new System.Drawing.Point(300, 56);
            this.txtLink.Name = "txtLink";
            this.helpProvider1.SetShowHelp(this.txtLink, true);
            this.txtLink.Size = new System.Drawing.Size(263, 20);
            this.txtLink.TabIndex = 1;
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVideo.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnVideo.FlatAppearance.BorderSize = 3;
            this.btnVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpProvider1.SetHelpString(this.btnVideo, "Haz click aquí para descargarte el vídeo entero.");
            this.btnVideo.Location = new System.Drawing.Point(21, 130);
            this.btnVideo.Name = "btnVideo";
            this.helpProvider1.SetShowHelp(this.btnVideo, true);
            this.btnVideo.Size = new System.Drawing.Size(263, 57);
            this.btnVideo.TabIndex = 2;
            this.btnVideo.Text = "Descargar Vídeo";
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpProvider1.SetHelpString(this.button2, "Haz click aquí para descargarte el audio (Canciones, podcast...etc.).");
            this.button2.Location = new System.Drawing.Point(300, 130);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(263, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Descargar Audio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpProvider1.SetHelpString(this.button3, "Haz click aquí elegir el destino de la descarga.");
            this.button3.Location = new System.Drawing.Point(21, 218);
            this.button3.Name = "button3";
            this.helpProvider1.SetShowHelp(this.button3, true);
            this.button3.Size = new System.Drawing.Size(263, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar en...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(435, 218);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(128, 23);
            this.pbProgress.TabIndex = 6;
            this.pbProgress.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Space Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProgress.Location = new System.Drawing.Point(323, 216);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(112, 25);
            this.lblProgress.TabIndex = 7;
            this.lblProgress.Text = "Progreso:";
            this.lblProgress.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bgwVideo
            // 
            this.bgwVideo.WorkerReportsProgress = true;
            this.bgwVideo.WorkerSupportsCancellation = true;
            this.bgwVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwVideo_DoWork);
            this.bgwVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwVideo_ProgressChanged);
            this.bgwVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwVideo_RunWorkerCompleted);
            // 
            // btnCancelPlaylist
            // 
            this.btnCancelPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnCancelPlaylist.FlatAppearance.BorderSize = 3;
            this.btnCancelPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPlaylist.Font = new System.Drawing.Font("Space Bd BT", 15.25F);
            this.btnCancelPlaylist.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpString(this.btnCancelPlaylist, "Haz click aquí para descargarte el audio (Canciones, podcast...etc.).");
            this.btnCancelPlaylist.Location = new System.Drawing.Point(328, 257);
            this.btnCancelPlaylist.Name = "btnCancelPlaylist";
            this.helpProvider1.SetShowHelp(this.btnCancelPlaylist, true);
            this.btnCancelPlaylist.Size = new System.Drawing.Size(244, 40);
            this.btnCancelPlaylist.TabIndex = 9;
            this.btnCancelPlaylist.Text = "Cancelar descarga";
            this.btnCancelPlaylist.UseVisualStyleBackColor = false;
            this.btnCancelPlaylist.Visible = false;
            this.btnCancelPlaylist.Click += new System.EventHandler(this.btnCancelPlaylist_Click);
            // 
            // cmGeneral
            // 
            this.cmGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developersTwitterToolStripMenuItem,
            this.applicationCloseToolStripMenuItem});
            this.cmGeneral.Name = "contextMenuStrip1";
            this.cmGeneral.Size = new System.Drawing.Size(211, 48);
            // 
            // developersTwitterToolStripMenuItem
            // 
            this.developersTwitterToolStripMenuItem.Name = "developersTwitterToolStripMenuItem";
            this.developersTwitterToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.developersTwitterToolStripMenuItem.Text = "Twitter del desarrollador...";
            this.developersTwitterToolStripMenuItem.Click += new System.EventHandler(this.twitterDelDesarrolladorToolStripMenuItem_Click);
            // 
            // applicationCloseToolStripMenuItem
            // 
            this.applicationCloseToolStripMenuItem.Name = "applicationCloseToolStripMenuItem";
            this.applicationCloseToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.applicationCloseToolStripMenuItem.Text = "Cerrar aplicación";
            this.applicationCloseToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblVideoTitle.Font = new System.Drawing.Font("Space Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVideoTitle.Location = new System.Drawing.Point(296, 88);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(0, 19);
            this.lblVideoTitle.TabIndex = 8;
            this.lblVideoTitle.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Space Bd BT", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.audioToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // saveInToolStripMenuItem
            // 
            this.saveInToolStripMenuItem.Name = "saveInToolStripMenuItem";
            this.saveInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveInToolStripMenuItem.Text = "Guardar en...";
            this.saveInToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espanolToolStripMenuItem,
            this.inglesToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // espanolToolStripMenuItem
            // 
            this.espanolToolStripMenuItem.CheckOnClick = true;
            this.espanolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("espanolToolStripMenuItem.Image")));
            this.espanolToolStripMenuItem.Name = "espanolToolStripMenuItem";
            this.espanolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.espanolToolStripMenuItem.Text = "Español";
            this.espanolToolStripMenuItem.CheckedChanged += new System.EventHandler(this.languageToolStripMenuItem_CheckedChanged);
            // 
            // inglesToolStripMenuItem
            // 
            this.inglesToolStripMenuItem.CheckOnClick = true;
            this.inglesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inglesToolStripMenuItem.Image")));
            this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
            this.inglesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inglesToolStripMenuItem.Text = "Inglés";
            this.inglesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.languageToolStripMenuItem_CheckedChanged);
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betterAudioQualityToolStripMenuItem});
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // betterAudioQualityToolStripMenuItem
            // 
            this.betterAudioQualityToolStripMenuItem.CheckOnClick = true;
            this.betterAudioQualityToolStripMenuItem.Name = "betterAudioQualityToolStripMenuItem";
            this.betterAudioQualityToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.betterAudioQualityToolStripMenuItem.Text = "Mejor calidad de audio";
            this.betterAudioQualityToolStripMenuItem.ToolTipText = "Busca mejor calidad de audio. \r\n\r\nAviso: Puede generar un tiempo de espera demasi" +
    "ado alto para cada archivo de audio.\r\n";
            this.betterAudioQualityToolStripMenuItem.CheckedChanged += new System.EventHandler(this.mejorCalidadDeAudioToolStripMenuItem_CheckedChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developersTwitterToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "Sobre";
            // 
            // developersTwitterToolStripMenuItem1
            // 
            this.developersTwitterToolStripMenuItem1.Name = "developersTwitterToolStripMenuItem1";
            this.developersTwitterToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.developersTwitterToolStripMenuItem1.Text = "Twitter del desarrollador";
            this.developersTwitterToolStripMenuItem1.Click += new System.EventHandler(this.twitterDelDesarrolladorToolStripMenuItem_Click);
            // 
            // Alcachofa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 309);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCancelPlaylist);
            this.Controls.Add(this.lblVideoTitle);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Alcachofa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alcachofa";
            this.cmGeneral.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker bgwVideo;
        private System.Windows.Forms.HelpProvider helpProvider1;
        
        private ContextMenuStrip cmGeneral;
        private ToolStripMenuItem developersTwitterToolStripMenuItem;
        private ToolStripMenuItem applicationCloseToolStripMenuItem;
        private Label lblVideoTitle;
        private Button btnCancelPlaylist;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveInToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem audioToolStripMenuItem;
        private ToolStripMenuItem betterAudioQualityToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem developersTwitterToolStripMenuItem1;
        private ToolStripMenuItem idiomaToolStripMenuItem;
        private ToolStripMenuItem espanolToolStripMenuItem;
        private ToolStripMenuItem inglesToolStripMenuItem;
    }
}

