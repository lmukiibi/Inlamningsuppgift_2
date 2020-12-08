using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Inlamningsuppgift_2
{
    class Gotebuggarna
    {
        private bool running;

        public Gotebuggarna()
        {
            running = false;
        }

        private void GetDataFromLink()
        {
            string urlAddress = "https://docs.google.com/spreadsheets/d/1OBbo8KQvtJaDHkG7gVHKCZULfzQ3DjygSfUjSB5WDf8/edit?usp=sharing";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UseDefaultCredentials = true;
            request.Accept = "/";
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                string data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                Console.WriteLine(data);
            }
        }

        public void Run()
        {
            while (true)
            {
                GetDataFromLink();
                Console.ReadKey();
            }
        }
    }
}
