namespace SlackControl
{
    public class ProfileSlack
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar_hash { get; set; }
        public string real_name { get; set; }
        public string real_name_normalized { get; set; }
        public string email { get; set; }
        public string image_48 { get; set; }
        public string image_72 { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string team_id { get; set; }
        public string name { get; set; }
        public string real_name { get; set; }
        public bool is_bot { get; set; }
        public ProfileSlack profile { get; set; }
    }

    public class RootObject
    {
        public bool ok { get; set; }
        public User user { get; set; }
    }
}
