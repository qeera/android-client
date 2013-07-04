using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Net;

namespace AndroidClient
{
    class Tools
    {
        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, t);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }

        public static String sendUrlGet(String inUrl)
        {
            Encoding encoding = Encoding.UTF8;
            WebClient webClient = new WebClient();
            byte[] buffer = webClient.DownloadData(inUrl);
            byte[] bom = encoding.GetPreamble();
            if ((0 == bom.Length) || (buffer.Length < bom.Length))
            {
                return encoding.GetString(buffer);
            }
            for (int i = 0; i < bom.Length; i++)
            {
                if (buffer[i] != bom[i])
                {
                    return encoding.GetString(buffer);
                }
            }
            return encoding.GetString(buffer, bom.Length, buffer.Length - bom.Length);
        }

        public static string sendJsonPost(string inUrl, string inJsonString)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(inUrl);
            httpWebRequest.ContentType = "application/json; charset=UTF-8";
            httpWebRequest.Method = "POST";
            httpWebRequest.Accept = "application/json";
            byte[] theData = Encoding.UTF8.GetBytes(inJsonString);
            httpWebRequest.ContentLength = theData.Length;


            Stream requestStream = httpWebRequest.GetRequestStream();
            requestStream.Write(theData, 0, theData.Length);
            requestStream.Flush();
            requestStream.Close();

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            //return string
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

    }
}
