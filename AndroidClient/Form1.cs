using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AndroidClient
{
    public partial class Form1 : Form
    {
        public qeeraAPI qeeraApi = new qeeraAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getTranslations_Click(object sender, EventArgs e)
        {
            string sTemplateFile = Properties.Settings.Default.export_templatefile;
            string sTargetFile = Properties.Settings.Default.export_targetfile;
            string sTargetLanguage = Properties.Settings.Default.export_targetlanguage;

            labelStatus.Text = "Get translations";
            List<TranslationData> aoTranslations = qeeraApi.getTranslations(sTargetLanguage);

            labelStatus.Text = "Export " + aoTranslations.Count.ToString() + " translations";
            qeeraApi.exportTranslations(sTemplateFile, sTargetFile , aoTranslations);
        }

        private void menu_version_Click(object sender, EventArgs e)
        {
            string sVersion = qeeraApi.getVersion();
            if (sVersion != "")
            {
                MessageBox.Show("API-Version : " + sVersion);
            }
        }

        private void menu_settings_Click(object sender, EventArgs e)
        {
            formSettings oFormSettings = new formSettings();
            oFormSettings.Show();
        }


        private void btnUpdateTokens_Click(object sender, EventArgs e)
        {
            List<string> lsTokens = qeeraApi.androidResourceXML2Tokens(Properties.Settings.Default.import_file);
            labelStatus.Text = "Found " + lsTokens .Count.ToString() + " Tokens";
            TokensResultData setTokensResult = qeeraApi.setTokens(lsTokens);
            labelStatus.Text = "Updated " + lsTokens.Count.ToString() + " Tokens";
            //log
            tbLog.AppendText("Update tokens" + Environment.NewLine);
            tbLog.AppendText(" > Tokens created : " + setTokensResult.create_token.ToString() + Environment.NewLine);
            tbLog.AppendText(" > Tokens updated : " + setTokensResult.update_token.ToString() + Environment.NewLine);
            tbLog.AppendText(" > Tokens obsolete : " + setTokensResult.obsolete_token.ToString() + Environment.NewLine);
        }
    }
}
