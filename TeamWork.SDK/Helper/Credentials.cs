
namespace TeamWork.SDK.Helper
{
    public class Credentials
    {
        public string ApiKey { get; set; }
        public string InstallationName { get; set; }

        /// <summary>
        /// Teamworks Api Key and Site Url's Installation name to be provided
        /// eg "https://installationname.teamwork.com/";
        /// </summary>
        public Credentials()
        {
            ApiKey = "";
            InstallationName = "";
        }

    }
}
