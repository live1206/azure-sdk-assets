// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal static partial class NetworkAclBypassExtensions
    {
        public static string ToSerialString(this NetworkAclBypass value) => value switch
        {
            NetworkAclBypass.None => "None",
            NetworkAclBypass.AzureServices => "AzureServices",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NetworkAclBypass value.")
        };

        public static NetworkAclBypass ToNetworkAclBypass(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return NetworkAclBypass.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AzureServices")) return NetworkAclBypass.AzureServices;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NetworkAclBypass value.");
        }
    }
}
