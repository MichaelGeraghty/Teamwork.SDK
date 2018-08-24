namespace TeamWork.SDK.TeamWorkService
{
    public class Config
    {
        public string ApiKey { get; set; }
        public string Domain { get; set; }
        /// <summary>
        /// Configuration for authorisation
        /// </summary>
        /// <param name="apiKey">string Teamwork api key</param>
        /// <param name="domain">string Teamwork site URL</param>
        public Config(string apiKey, string domain)
        {
            this.ApiKey = apiKey;
            this.Domain = domain;
        }
    }
}
