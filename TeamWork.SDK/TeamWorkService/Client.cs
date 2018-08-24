using System;

namespace TeamWork.SDK.TeamWorkService
{
    public class Client
    {
        public string InstallName { get; set; }
        private string baseUrl;
        public string BaseUrl
        {
            get
            {
                if (string.IsNullOrEmpty(baseUrl)) throw new Exception("You need to Initialize the client first");
                return baseUrl;
            }
            private set { baseUrl = value; }
        }

        private string apiKey;
        public string APiKey
        {
            get
            {
                if (string.IsNullOrEmpty(apiKey)) throw new Exception("You need to Initialize the client first");
                return apiKey;
            }
            private set
            {
                if (value == null) throw new ArgumentNullException("APiKey");
                apiKey = value;
            }
        }
        /// <summary>
        /// Initialise Client with valid configuration
        /// </summary>
        /// <param name="apiKey">string Teamwork api key</param>
        /// <param name="installationName">string Teamwork site URL</param>
        /// <param name="domain">teamwork.com domain</param>
        public void Init(string apiKey, string installationName, string domain = "teamwork.com")
        {
            InstallName = installationName;
            BaseUrl = "https://" + installationName + "." + domain + "/";
            APiKey = apiKey;
        }
    }
}
