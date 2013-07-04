using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace AndroidClient
{
    public class qeeraAPI
    {
        public string API_URL = Properties.Settings.Default.api_url + "/" + Properties.Settings.Default.organization + "/api/?format=JSON&key=" + Properties.Settings.Default.api_key + "&project=" + Properties.Settings.Default.project;

        public string getVersion()
        {
             string result = "";
             Cursor.Current = Cursors.WaitCursor;
             APIversion oAPIversion = Tools.JsonDeserialize<APIversion>(Tools.sendUrlGet(API_URL + "&cmd=VERSION"));
             if (oAPIversion.status_code == 1)
             {
                 result = oAPIversion.data.version;
             }
             else
             {
                 MessageBox.Show("Error + " + oAPIversion.status_message);
             }
             Cursor.Current = Cursors.Default;
             return result;

        }

        public List<TranslationData> getTranslations(string sLanguage)
        {
            List<TranslationData> result = null;
            Cursor.Current = Cursors.WaitCursor;
            APItranslations oAPItranslations = Tools.JsonDeserialize<APItranslations>(Tools.sendUrlGet(API_URL + "&cmd=GETTRANSLATIONS&language=" + sLanguage));
            if (oAPItranslations.status_code == 1)
            {
                result = oAPItranslations.data;
            }
            else
            {
                MessageBox.Show("Error + " + oAPItranslations.status_message);
            }
            Cursor.Current = Cursors.Default;
            return result;
        }

        public void exportTranslations(string sTemplateFile, string sTargetFile , List<TranslationData> aoTranslations)
        {

            string sTargetContent = "";

            //load file
            string sTemplateFileContent = File.ReadAllText(sTemplateFile);
            Console.WriteLine(sTemplateFileContent);

            //get loop content
            string sLoopStart = "{{loop}}";
            string sLoopEnd = "{{endloop}}";
            int iLoopStart = sTemplateFileContent.IndexOf(sLoopStart);
            int iLoopEnd = sTemplateFileContent.IndexOf(sLoopEnd, iLoopStart);
            string sLoopTemplate = sTemplateFileContent.Substring(iLoopStart + sLoopStart.Length, iLoopEnd - iLoopStart - sLoopStart.Length);
            Console.WriteLine(sLoopTemplate);

            //replace loop-template-text
            string sLoopText = "";
            string sLoopItemText = "";
            foreach (var oTranslation in aoTranslations)
            {
                sLoopItemText = sLoopTemplate;
                sLoopItemText = sLoopItemText.Replace("{{token}}", oTranslation.token);
                sLoopItemText = sLoopItemText.Replace("{{translation}}", oTranslation.translation);
                sLoopItemText = sLoopItemText.Replace("{{user}}", oTranslation.user);
                sLoopItemText = sLoopItemText.Replace("{{status}}", oTranslation.status);
                sLoopItemText = sLoopItemText.Replace("{{time_create}}", oTranslation.time_create);
                sLoopItemText = sLoopItemText.Replace("{{time_update}}", oTranslation.time_update);
                sLoopText += sLoopItemText;
            }

            //output target
            sTargetContent = sTemplateFileContent.Substring(0, iLoopStart) + sLoopText + sTemplateFileContent.Substring(iLoopEnd + sLoopEnd.Length);
            File.WriteAllText(sTargetFile, sTargetContent);
        }

        public List<string> androidResourceXML2Tokens(string sImportFile)
        {
            List<string> lsResult = new List<string>();

            XmlSerializer ser = new XmlSerializer(typeof(AndroidResources));
            AndroidResources androidResources;
            using (XmlReader reader = XmlReader.Create(sImportFile))
            {
                androidResources = (AndroidResources)ser.Deserialize(reader);
            }

            foreach (var androidResource in androidResources.Items)
            {
                lsResult.Add(androidResource.name);
            }
            return lsResult;
            
        }

        public TokensResultData setTokens(List<string> lsTokens)
        {
            Cursor.Current = Cursors.WaitCursor;
            TokensResultData oResult = null;
            string sUrl = API_URL + "&cmd=SETTOKENS&flag=FULL";
            string sJson = Tools.JsonSerializer<List<string>>(lsTokens);
            string sResultJson = Tools.sendJsonPost(sUrl, sJson);
            Cursor.Current = Cursors.Default;

            APIsetTokensResult setTokensResult = Tools.JsonDeserialize<APIsetTokensResult>(sResultJson);
            if (setTokensResult.status_code == 1)
            {
                 oResult = setTokensResult.data;
            }
            return oResult; 
        }

    }


    public class TokensResultData
    {
        public int create_token { get; set; }
        public string create_token_csv { get; set; }
        public int update_token { get; set; }
        public string update_token_csv { get; set; }
        public int obsolete_token { get; set; }
        public string obsolete_token_csv { get; set; }
    }

    public class APIsetTokensResult
    {
        public int status_code { get; set; }
        public string status_message { get; set; }
        public TokensResultData data { get; set; }

    }

    public class VersionData
    {
        public string version { get; set; }
    }

    public class APIversion
    {
        public int status_code { get; set; }
        public string status_message { get; set; }
        public VersionData data { get; set; }

    }

    public class TranslationData
    {
        public string translation { get; set; }
        public string token { get; set; }
        public string user { get; set; }
        public string status { get; set; }
        public string time_create { get; set; }
        public string time_update { get; set; }
    }

    public class APItranslations
    {
        public int status_code { get; set; }
        public string status_message { get; set; }
        public List<TranslationData> data { get; set; }
    }
}
