﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PnP.Core.Auth.Test.Utilities
{
    internal static class TestGlobals
    {
        internal static Uri GraphResource = new Uri("https://graph.microsoft.com");
        internal static string GraphMeRequest = "https://graph.microsoft.com/v1.0/me";
        internal static Uri OnBehalfOfBackendResource = new Uri("api://pnp.core.test.onbehalfof.backend");

        internal static string CredentialsConfigurationBasePath = "PnPCore:Credentials:Configurations";
        internal static string SitesConfigurationBasePath = "PnPCore:Sites";
    }
}
