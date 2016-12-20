using SlackControl.Configuration;
using SlackControl.Models;
using SlackControl.Profile;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace SlackControl
{
    public partial class Slack : UserControl
    {
        private string filename = Path.Combine(Environment.CurrentDirectory, "config.json");
        private userdata user;
        private string userId, uName, profImg;

        public Slack()
        {
            InitializeComponent();
        }
        private void btn_slack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Config cc = new Config();
                bool boolbtn = cc.getToken();
                if (cc.Connect() != null)
                {
                    if (boolbtn == true)
                    {
                        display_info();
                        signIn();
                    }
                    else
                    {
                        label2.Content = "Invalid Code";
                    }
                }
                else
                {
                    label2.Content = "Authorization Not Granted";
                }
            }
            finally
            {
            }
        }

        private void display_info()
        {
            try
            {
                var configc = new Config().Connect();
                if (configc != null)
                {
                    userId = configc.TestUserId;
                    ProfileInfo prof = new ProfileInfo();
                    prof.getUserInfo(userId);
                    profImg = prof._profileImg;
                    uName = prof._userName;
                    user = new userdata
                    {
                        profileImage = profImg,
                        userID = userId,
                        userName = uName,
                    };
                    DataContext = user;
                }
            }
            finally
            {

            }
        }
 
        private void deleteToken()
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                file.WriteLine(" ");
            }
        }
        private void signIn()
        {
            label2.Content = "You are Signed In";
        }
    }
}

