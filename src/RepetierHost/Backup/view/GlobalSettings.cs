/*
   Copyright 2011 repetier repetierdev@gmail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using RepetierHost.view.utils;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class GlobalSettings : Form
    {
        RegistryKey repetierKey;

        public GlobalSettings()
        {
            InitializeComponent();
            RegMemory.RestoreWindowPos("globalSettingsWindow", this);
            repetierKey = Custom.BaseKey; // Registry.CurrentUser.CreateSubKey("SOFTWARE\\Repetier");
            RegToForm();
            translate();
            Main.main.languageChanged += translate;
        }
        public void translate()
        {
            Text = Trans.T("W_REPETIER_SETTINGS");
            groupBehaviour.Text = Trans.T("L_BEHAVIOUR");
            groupFilesAndDirectories.Text = Trans.T("L_FILES_AND_DIRECTORIES");
            groupGUI.Text = Trans.T("L_GUI");
            labelInfoWorkdir.Text = Trans.T("L_INFO_WORKDIR");
            checkLogfile.Text = Trans.T("L_LOG_SESSION");
            checkReduceToolbarSize.Text = Trans.T("REDUCE_TOOLBAR_SIZE");
            checkDisableQualityReduction.Text = Trans.T("L_DISABLE_QUALITY_REDUCTION");
            labelWorkdir.Text = Trans.T("L_WORKDIR:");
            buttonSearchWorkdir.Text = Trans.T("B_BROWSE");
            folderBrowser.Description = Trans.T("L_SELECT_WORKING_DIRECTORY"); // Select working directory
            checkRedGreenSwitch.Text = Trans.T("L_USE_RED_GREEN_SWITCH");
            buttonAbort.Text = Trans.T("B_CANCEL");
            buttonOK.Text = Trans.T("B_OK");
        }
        public bool WorkdirOK()
        {
            string wd = Workdir;
            if (wd.Length == 0 || !Directory.Exists(wd))
            {
                labelOKMasg.Text = Trans.T("L_EXISTING_WORKDIR_REQUIRED"); // "Existing work directory required!";
                return false;
            }
            labelOKMasg.Text = "";
            return true;
        }
        public void FormToReg()
        {
            repetierKey.SetValue("workdir", Workdir);
            repetierKey.SetValue("logEnabled", LogEnabled ? 1 : 0);
            repetierKey.SetValue("disableQualityReduction", DisableQualityReduction ? 1 : 0);
            repetierKey.SetValue("reduceToolbarSize", ReduceToolbarSize ? 1 : 0);
            RegMemory.SetInt("onOffImageOffset", checkRedGreenSwitch.Checked ? 2 : 0);
        }
        public void RegToForm()
        {
            Workdir = (string)repetierKey.GetValue("workdir", Workdir);
            checkLogfile.Checked = 1== (int) repetierKey.GetValue("logEnabled", LogEnabled ? 1 : 0);
            checkDisableQualityReduction.Checked = 1 == (int)repetierKey.GetValue("disableQualityReduction", DisableQualityReduction ? 1 : 0);
            checkReduceToolbarSize.Checked = 1 == (int)repetierKey.GetValue("reduceToolbarSize", ReduceToolbarSize ? 1 : 0);
            checkRedGreenSwitch.Checked = 2 == RegMemory.GetInt("onOffImageOffset", 0);
        }
        public string Workdir
        {
            get { return textWorkdir.Text; }
            set { textWorkdir.Text = value; }
        }
        public Boolean LogEnabled
        {
            get { return checkLogfile.Checked; }
        }
        public Boolean DisableQualityReduction
        {
            get { return checkDisableQualityReduction.Checked; }
        }
        public Boolean ReduceToolbarSize
        {
            get { return checkReduceToolbarSize.Checked; }
        }
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            RegToForm();
            if(WorkdirOK())
                Hide();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormToReg();
            if(WorkdirOK())
                Hide();
        }

        private void buttonSearchWorkdir_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textWorkdir.Text = folderBrowser.SelectedPath;
            }
        }

        private void GlobalSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegMemory.StoreWindowPos("globalSettingsWindow", this, false, false);
        }

        private void textWorkdir_TextChanged(object sender, EventArgs e)
        {
            WorkdirOK();
        }

        private void checkReduceToolbarSize_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.UpdateToolbarSize();
        }
    }
}
