using System.Configuration;
using Microsoft.Web.WebPages.OAuth;

namespace Oahu
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterTwitterClient(ConfigurationManager.AppSettings["TwitterConsumerKey"], ConfigurationManager.AppSettings["TwitterConsumerSecret"]);
            OAuthWebSecurity.RegisterMicrosoftClient(ConfigurationManager.AppSettings["MicrosoftClientId"], ConfigurationManager.AppSettings["MicrosoftClientSecret"]);
            OAuthWebSecurity.RegisterFacebookClient(ConfigurationManager.AppSettings["FacebookAppId"], ConfigurationManager.AppSettings["FacebookAppSecret"]);
            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
