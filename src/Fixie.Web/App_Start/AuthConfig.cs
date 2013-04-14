using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;

namespace Fixie.Web
{
    public class AuthConfig
    {
        public static void RegisterAuth()
        {
            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}