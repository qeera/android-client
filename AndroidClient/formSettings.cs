using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AndroidClient
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.organization = tbOrganization.Text;
            Properties.Settings.Default.project = tbProject.Text;
            Properties.Settings.Default.api_key = tbAPIKey.Text;
            Properties.Settings.Default.export_targetfile = tbExportTargetfile.Text;
            Properties.Settings.Default.export_targetlanguage = tbExportTargetlanguage.Text;
            Properties.Settings.Default.export_templatefile = tbExportTemplate.Text;
            Properties.Settings.Default.import_file = tbImportFile.Text; 
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void formSettings_Shown(object sender, EventArgs e)
        {
            tbOrganization.Text = Properties.Settings.Default.organization;
            tbProject.Text = Properties.Settings.Default.project;
            tbAPIKey.Text = Properties.Settings.Default.api_key;
            tbExportTargetfile.Text = Properties.Settings.Default.export_targetfile;
            tbExportTargetlanguage.Text = Properties.Settings.Default.export_targetlanguage;
            tbExportTemplate.Text = Properties.Settings.Default.export_templatefile;
            tbImportFile.Text = Properties.Settings.Default.import_file;
        }

        private void btnChangeTargetFile_Click(object sender, EventArgs e)
        {
            dlgChangeTargetfile.FileName = Properties.Settings.Default.export_targetfile;
            dlgChangeTargetfile.ShowDialog();
            if(dlgChangeTargetfile.FileName != "")
            {
                tbExportTargetfile.Text = dlgChangeTargetfile.FileName;
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            qeeraAPI qeeraApi = new qeeraAPI();
            if (qeeraApi.getVersion() != "")
            {
                MessageBox.Show("Connection OK");
            }
        }

        private void btnChangeImportFile_Click(object sender, EventArgs e)
        {
            dlgChangeTargetfile.FileName = Properties.Settings.Default.import_file;
            dlgChangeTargetfile.ShowDialog();
            if (dlgChangeTargetfile.FileName != "")
            {
                tbImportFile.Text = dlgChangeTargetfile.FileName;
            }
        }


    }
}
