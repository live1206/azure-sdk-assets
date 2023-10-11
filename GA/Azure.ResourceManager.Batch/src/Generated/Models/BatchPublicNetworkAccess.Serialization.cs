// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchPublicNetworkAccessExtensions
    {
        public static string ToSerialString(this BatchPublicNetworkAccess value) => value switch
        {
            BatchPublicNetworkAccess.Enabled => "Enabled",
            BatchPublicNetworkAccess.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchPublicNetworkAccess value.")
        };

        public static BatchPublicNetworkAccess ToBatchPublicNetworkAccess(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Enabled")) return BatchPublicNetworkAccess.Enabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Disabled")) return BatchPublicNetworkAccess.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchPublicNetworkAccess value.");
        }
    }
}
