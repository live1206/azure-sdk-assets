// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    internal static partial class MarketplaceTypeExtensions
    {
        public static string ToSerialString(this MarketplaceType value) => value switch
        {
            MarketplaceType.NotSpecified => "NotSpecified",
            MarketplaceType.AddOn => "AddOn",
            MarketplaceType.Bypass => "Bypass",
            MarketplaceType.Store => "Store",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MarketplaceType value.")
        };

        public static MarketplaceType ToMarketplaceType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSpecified")) return MarketplaceType.NotSpecified;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AddOn")) return MarketplaceType.AddOn;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Bypass")) return MarketplaceType.Bypass;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Store")) return MarketplaceType.Store;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MarketplaceType value.");
        }
    }
}