using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepetierHost.Replicator3D
{
    public partial class Configuration : Form
    {
        Settings settings;

        string NO_FILE = "No file selected.", NO_DIR = "No directory selected.";

        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            if (string.IsNullOrEmpty(settings.DAVIDLaserscanner))
            {
                lblDLSExe.Text = NO_FILE;
            }
            if (string.IsNullOrEmpty(settings.Processing))
            {
                lblPExe.Text = NO_FILE;
            }
            if (string.IsNullOrEmpty(settings.Directory))
            {
                lblDirectoryS.Text = NO_DIR;
            }
        }

        private void btnDLS_Click(object sender, EventArgs e)
        {
            ofdConfiguration.ShowDialog();
            if (!string.IsNullOrEmpty(ofdConfiguration.FileName))
            {
                settings.DAVIDLaserscanner = ofdConfiguration.FileName;
                lblDLSExe.Text = ofdConfiguration.FileName;
            }
            else
            {
                settings.DAVIDLaserscanner = string.Empty;
                lblDLSExe.Text = NO_FILE;
            }
            settings.Save();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            ofdConfiguration.ShowDialog();
            if (!string.IsNullOrEmpty(ofdConfiguration.FileName))
            {
                settings.Processing = ofdConfiguration.FileName;
                lblPExe.Text = ofdConfiguration.FileName;
            }
            else
            {
                settings.Processing = string.Empty;
                lblPExe.Text = NO_FILE;
            }
            settings.Save();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            ofdConfiguration.ShowDialog();
            if (!string.IsNullOrEmpty(ofdConfiguration.FileName))
            {
                settings.Directory = ofdConfiguration.FileName;
                lblDirectoryS.Text = ofdConfiguration.FileName;
            }
            else
            {
                settings.Directory = string.Empty;
                lblDirectoryS.Text = NO_DIR;
            }
            settings.Save();
        }
    }
}
