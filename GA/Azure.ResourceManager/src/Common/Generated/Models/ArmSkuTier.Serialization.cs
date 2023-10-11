// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Models
{
    internal static partial class ArmSkuTierExtensions
    {
        public static string ToSerialString(this ArmSkuTier value) => value switch
        {
            ArmSkuTier.Free => "Free",
            ArmSkuTier.Basic => "Basic",
            ArmSkuTier.Standard => "Standard",
            ArmSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArmSkuTier value.")
        };

        public static ArmSkuTier ToArmSkuTier(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Free")) return ArmSkuTier.Free;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Basic")) return ArmSkuTier.Basic;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard")) return ArmSkuTier.Standard;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Premium")) return ArmSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArmSkuTier value.");
        }
    }
}