using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Web;
using GoogleAuthentication.Models;
using GoogleAuthentication.Services;

namespace GoogleAuthentication.Services
{
    public class GoogleAuthenticatorService
    {
        public TwoFactorAuthenticator GetAuthenticator() => new TwoFactorAuthenticator();

        public SetupCode GenerateSetupCode(string account, string key)
        {
            var tfa = GetAuthenticator();
            return tfa.GenerateSetupCode("SecurityApp", account, key, false, 3);
        }

        public bool ValidateCode(string key, string code)
        {
            var tfa = GetAuthenticator();
            return tfa.ValidateTwoFactorPIN(key, code);
        }
    }
}