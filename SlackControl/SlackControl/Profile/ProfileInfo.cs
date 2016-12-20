using Newtonsoft.Json;
using SlackControl.Configuration;
using System.Net;

namespace SlackControl.Profile
{
    class ProfileInfo
    {
        private string profileImage, email, userName;
        public string _userName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string _email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string _profileImg
        {
            get
            {
                return profileImage;
            }
            set
            {
                profileImage = value;
            }
        }
        public string getUserInfo(string ID)
        {
            var config = new Config().Connect();
            if (config.ApiToken != "")
            {
                string URL = "https://slack.com/api/users.info?token=" + config.ApiToken + "&user=" + ID + "&pretty=1";
                var client = new WebClient();
                var json = client.DownloadString(URL);
             
                RootObject prof = new RootObject();
                prof = JsonConvert.DeserializeObject<RootObject>(json);
                json = WebUtility.HtmlDecode(json);
                if (prof.ok==true)
                {
                    userName = prof.user.name;
                    profileImage = prof.user.profile.image_72;
                    email = prof.user.profile.email;
                }
            }
            return userName;
        }

    }
}
