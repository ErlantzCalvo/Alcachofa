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
            this.lblEnlace = new System.Windows.Forms.Label();
            this.txtEnlace = new System.Windows.Forms.TextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bgwVideo = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.cmTwitter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.twitterDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTituloVideo = new System.Windows.Forms.Label();
            this.cmTwitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnlace
            // 
            this.lblEnlace.AutoSize = true;
            this.lblEnlace.BackColor = System.Drawing.Color.Transparent;
            this.lblEnlace.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnlace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEnlace.Location = new System.Drawing.Point(15, 44);
            this.lblEnlace.Name = "lblEnlace";
            this.lblEnlace.Size = new System.Drawing.Size(279, 32);
            this.lblEnlace.TabIndex = 0;
            this.lblEnlace.Text = "Enlace de YouTube :";
            // 
            // txtEnlace
            // 
            this.helpProvider1.SetHelpString(this.txtEnlace, "Pega aquí el enlace de un vídeo de YouTube.");
            this.txtEnlace.Location = new System.Drawing.Point(300, 56);
            this.txtEnlace.Name = "txtEnlace";
            this.helpProvider1.SetShowHelp(this.txtEnlace, true);
            this.txtEnlace.Size = new System.Drawing.Size(263, 20);
            this.txtEnlace.TabIndex = 1;
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
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(435, 218);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(128, 23);
            this.pbProgreso.TabIndex = 6;
            this.pbProgreso.Visible = false;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.BackColor = System.Drawing.Color.Transparent;
            this.lblProgreso.Font = new System.Drawing.Font("Space Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProgreso.Location = new System.Drawing.Point(323, 216);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(112, 25);
            this.lblProgreso.TabIndex = 7;
            this.lblProgreso.Text = "Progreso:";
            this.lblProgreso.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bgwVideo
            // 
            this.bgwVideo.WorkerReportsProgress = true;
            this.bgwVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwVideo_DoWork);
            this.bgwVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwVideo_ProgressChanged);
            this.bgwVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwVideo_RunWorkerCompleted);
            // 
            // cmTwitter
            // 
            this.cmTwitter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterDelDesarrolladorToolStripMenuItem,
            this.cerrarAplicaciónToolStripMenuItem});
            this.cmTwitter.Name = "contextMenuStrip1";
            this.cmTwitter.Size = new System.Drawing.Size(212, 48);
            // 
            // twitterDelDesarrolladorToolStripMenuItem
            // 
            this.twitterDelDesarrolladorToolStripMenuItem.Name = "twitterDelDesarrolladorToolStripMenuItem";
            this.twitterDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.twitterDelDesarrolladorToolStripMenuItem.Text = "Twitter del desarrollador...";
            this.twitterDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.twitterDelDesarrolladorToolStripMenuItem_Click);
            // 
            // cerrarAplicaciónToolStripMenuItem
            // 
            this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
            this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar aplicación";
            this.cerrarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // lblTituloVideo
            // 
            this.lblTituloVideo.AutoSize = true;
            this.lblTituloVideo.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVideo.Font = new System.Drawing.Font("Space Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloVideo.Location = new System.Drawing.Point(323, 261);
            this.lblTituloVideo.Name = "lblTituloVideo";
            this.lblTituloVideo.Size = new System.Drawing.Size(0, 25);
            this.lblTituloVideo.TabIndex = 8;
            this.lblTituloVideo.Visible = false;
            // 
            // Alcachofa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 309);
            this.Controls.Add(this.lblTituloVideo);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.pbProgreso);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.txtEnlace);
            this.Controls.Add(this.lblEnlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alcachofa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alcachofa";
            this.cmTwitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnlace;
        private System.Windows.Forms.TextBox txtEnlace;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lblProgreso;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker bgwVideo;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private ContextMenu cm;
        private ContextMenuStrip cmTwitter;
        private ToolStripMenuItem twitterDelDesarrolladorToolStripMenuItem;
        private ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
        private Label lblTituloVideo;
    }
}

