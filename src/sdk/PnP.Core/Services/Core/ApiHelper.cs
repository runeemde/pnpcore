﻿using System;
using System.Text.RegularExpressions;
using PnP.Core.Model;

namespace PnP.Core.Services
{
    /// <summary>
    /// Helper class to manage API calls URLs
    /// </summary>
    internal static class ApiHelper
    {
        internal static string ParseApiCall(TransientObject pnpObject, string apiCall, bool useGraph, bool skipMetadataLookup = false)
        {
            var metadataBasedObject = pnpObject as IMetadataExtensible;

            if (!skipMetadataLookup && !useGraph && metadataBasedObject.Metadata.ContainsKey("uri"))
            {
                return metadataBasedObject.Metadata["uri"];
            }

            // No tokens, so nothing to do parse
            if (!apiCall.Contains("{"))
            {
                return apiCall;
            }

            // Parse api call to replace tokens
            apiCall = ParseApiRequest(metadataBasedObject, apiCall);

            return apiCall;
        }

        internal static string ParseApiRequest(IMetadataExtensible pnpObject, string input)
        {
            var result = TokenHandler.ResolveTokensAsync(pnpObject, input)
                .GetAwaiter().GetResult();

            return result;
        }
    }
}
