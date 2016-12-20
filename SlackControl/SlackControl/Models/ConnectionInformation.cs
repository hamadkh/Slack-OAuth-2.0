namespace SlackControl.Models
{
    class ConnectionInformation
    {
        public bool ok { get; set; }
        public string access_token { get; set; }
        public string scope { get; set; }
        public string user_id { get; set; }
        public string team_name { get; set; }
        public string team_id { get; set; }
    }
}
