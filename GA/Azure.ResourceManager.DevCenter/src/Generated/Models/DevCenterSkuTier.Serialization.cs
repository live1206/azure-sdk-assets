// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal static partial class DevCenterSkuTierExtensions
    {
        public static string ToSerialString(this DevCenterSkuTier value) => value switch
        {
            DevCenterSkuTier.Free => "Free",
            DevCenterSkuTier.Basic => "Basic",
            DevCenterSkuTier.Standard => "Standard",
            DevCenterSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DevCenterSkuTier value.")
        };

        public static DevCenterSkuTier ToDevCenterSkuTier(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Free")) return DevCenterSkuTier.Free;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Basic")) return DevCenterSkuTier.Basic;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard")) return DevCenterSkuTier.Standard;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Premium")) return DevCenterSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DevCenterSkuTier value.");
        }
    }
}