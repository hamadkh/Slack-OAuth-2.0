using Newtonsoft.Json;
using SlackControl.Models;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace SlackControl.Configuration
{
    class Config
    {
        string filename = Path.Combine(Environment.CurrentDirectory, "config.json");
        bool btn = false;
        public SlackConfig Connect()
        {
            using (StreamReader file = new StreamReader(filename))
            {
                var json = file.ReadLine();
                ConnectionInformation getToken = new ConnectionInformation();
                getToken = JsonConvert.DeserializeObject<ConnectionInformation>(json);
                json = WebUtility.HtmlDecode(json);
                if (getToken != null && getToken.ok == true)
                {
                    var apiToken = getToken.access_token;
                    var userId = getToken.user_id;

                    var connection = new SlackConfig
                    {
                        ApiToken = apiToken,
                        TestUserId = userId
                    };

                    return connection;
                }
                else
                    return null;
            }
        }
        public bool getToken()
        {
            try
            {
                /*   Client_secret when regenerated update in this method
                 *   Enter Client Secret and ID in this method   
                 */
                 
                var client_secret = ""; 
                var client_id = "";

                var URL = "https://slack.com/oauth/authorize?scope=client&client_id=" + client_id;
                System.Diagnostics.Process.Start(URL);
                var getURL = Microsoft.VisualBasic.Interaction.InputBox("Enter URL", "Slack Code");
                string codeurl = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)";

                if (getURL != null && getURL !=" " && Regex.IsMatch(getURL, codeurl) == true)
                {
                    var index = getURL.IndexOf('?');

                    if (index != -1)
                        getURL = getURL.Substring(index + 1);

                    var qs = RestSharp.Extensions.MonoHttp.HttpUtility.ParseQueryString(getURL);
                    var code = qs["code"];
                    var newState = qs["state"];
                    string OAuth = "https://slack.com/api/oauth.access?client_id=" + client_id + "&client_secret=" + client_secret + "&code=" + code;
                    var client = new WebClient();
                    var json = client.DownloadString(OAuth);
                    using (StreamWriter file = new StreamWriter(filename))
                    {
                        file.WriteLine(json);
                    }
                    btn = true;
                }
            }
            finally
            {
            }
            return btn;
        }
    }
}
