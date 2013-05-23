namespace RepetierHost.Replicator3D
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.lblDLS = new System.Windows.Forms.Label();
            this.btnDLS = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.lblDLSExe = new System.Windows.Forms.Label();
            this.lblPExe = new System.Windows.Forms.Label();
            this.gbExec = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblDirectoryS = new System.Windows.Forms.Label();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pbMarconi = new System.Windows.Forms.PictureBox();
            this.ofdConfiguration = new System.Windows.Forms.OpenFileDialog();
            this.fbdConfiguration = new System.Windows.Forms.FolderBrowserDialog();
            this.gbExec.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarconi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDLS
            // 
            this.lblDLS.AutoSize = true;
            this.lblDLS.ForeColor = System.Drawing.Color.Black;
            this.lblDLS.Location = new System.Drawing.Point(6, 24);
            this.lblDLS.Name = "lblDLS";
            this.lblDLS.Size = new System.Drawing.Size(107, 13);
            this.lblDLS.TabIndex = 0;
            this.lblDLS.Text = "DAVID Laserscanner";
            // 
            // btnDLS
            // 
            this.btnDLS.ForeColor = System.Drawing.Color.Black;
            this.btnDLS.Location = new System.Drawing.Point(307, 19);
            this.btnDLS.Name = "btnDLS";
            this.btnDLS.Size = new System.Drawing.Size(104, 23);
            this.btnDLS.TabIndex = 1;
            this.btnDLS.Text = "Select executable";
            this.btnDLS.UseVisualStyleBackColor = true;
            this.btnDLS.Click += new System.EventHandler(this.btnDLS_Click);
            // 
            // btnP
            // 
            this.btnP.ForeColor = System.Drawing.Color.Black;
            this.btnP.Location = new System.Drawing.Point(307, 48);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(104, 23);
            this.btnP.TabIndex = 2;
            this.btnP.Text = "Select executable";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.ForeColor = System.Drawing.Color.Black;
            this.lblP.Location = new System.Drawing.Point(6, 53);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(59, 13);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "Processing";
            // 
            // lblDLSExe
            // 
            this.lblDLSExe.AutoSize = true;
            this.lblDLSExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLSExe.ForeColor = System.Drawing.Color.Black;
            this.lblDLSExe.Location = new System.Drawing.Point(120, 24);
            this.lblDLSExe.Name = "lblDLSExe";
            this.lblDLSExe.Size = new System.Drawing.Size(83, 13);
            this.lblDLSExe.TabIndex = 4;
            this.lblDLSExe.Text = "No file selected.";
            // 
            // lblPExe
            // 
            this.lblPExe.AutoSize = true;
            this.lblPExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPExe.ForeColor = System.Drawing.Color.Black;
            this.lblPExe.Location = new System.Drawing.Point(120, 53);
            this.lblPExe.Name = "lblPExe";
            this.lblPExe.Size = new System.Drawing.Size(83, 13);
            this.lblPExe.TabIndex = 5;
            this.lblPExe.Text = "No file selected.";
            // 
            // gbExec
            // 
            this.gbExec.Controls.Add(this.lblDLS);
            this.gbExec.Controls.Add(this.lblPExe);
            this.gbExec.Controls.Add(this.btnDLS);
            this.gbExec.Controls.Add(this.lblDLSExe);
            this.gbExec.Controls.Add(this.btnP);
            this.gbExec.Controls.Add(this.lblP);
            this.gbExec.ForeColor = System.Drawing.Color.Red;
            this.gbExec.Location = new System.Drawing.Point(12, 12);
            this.gbExec.Name = "gbExec";
            this.gbExec.Size = new System.Drawing.Size(417, 85);
            this.gbExec.TabIndex = 6;
            this.gbExec.TabStop = false;
            this.gbExec.Text = "External applications";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblDirectoryS);
            this.gbOptions.Controls.Add(this.btnDirectory);
            this.gbOptions.Controls.Add(this.lblDirectory);
            this.gbOptions.ForeColor = System.Drawing.Color.Red;
            this.gbOptions.Location = new System.Drawing.Point(12, 103);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(417, 59);
            this.gbOptions.TabIndex = 7;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Additional options";
            // 
            // lblDirectoryS
            // 
            this.lblDirectoryS.AutoSize = true;
            this.lblDirectoryS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectoryS.ForeColor = System.Drawing.Color.Black;
            this.lblDirectoryS.Location = new System.Drawing.Point(120, 24);
            this.lblDirectoryS.Name = "lblDirectoryS";
            this.lblDirectoryS.Size = new System.Drawing.Size(110, 13);
            this.lblDirectoryS.TabIndex = 2;
            this.lblDirectoryS.Text = "No directory selected.";
            // 
            // btnDirectory
            // 
            this.btnDirectory.ForeColor = System.Drawing.Color.Black;
            this.btnDirectory.Location = new System.Drawing.Point(307, 19);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(104, 23);
            this.btnDirectory.TabIndex = 1;
            this.btnDirectory.Text = "Select directory";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.ForeColor = System.Drawing.Color.Black;
            this.lblDirectory.Location = new System.Drawing.Point(6, 24);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(49, 13);
            this.lblDirectory.TabIndex = 0;
            this.lblDirectory.Text = "Directory";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(354, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(273, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pbMarconi
            // 
            this.pbMarconi.BackgroundImage = global::RepetierHost.Properties.Resources.logo;
            this.pbMarconi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMarconi.Location = new System.Drawing.Point(12, 199);
            this.pbMarconi.Name = "pbMarconi";
            this.pbMarconi.Size = new System.Drawing.Size(417, 105);
            this.pbMarconi.TabIndex = 10;
            this.pbMarconi.TabStop = false;
            // 
            // ofdConfiguration
            // 
            this.ofdConfiguration.FileName = "openFileDialog1";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 314);
            this.Controls.Add(this.pbMarconi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbExec);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuration";
            this.Text = "Configuration for 3D Replicator";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.gbExec.ResumeLayout(false);
            this.gbExec.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarconi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDLS;
        private System.Windows.Forms.Button btnDLS;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblDLSExe;
        private System.Windows.Forms.Label lblPExe;
        private System.Windows.Forms.GroupBox gbExec;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lblDirectoryS;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pbMarconi;
        private System.Windows.Forms.OpenFileDialog ofdConfiguration;
        private System.Windows.Forms.FolderBrowserDialog fbdConfiguration;
    }
}