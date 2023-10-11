// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Orbital.Models
{
    internal static partial class AutoTrackingConfigurationExtensions
    {
        public static string ToSerialString(this AutoTrackingConfiguration value) => value switch
        {
            AutoTrackingConfiguration.Disabled => "disabled",
            AutoTrackingConfiguration.XBand => "xBand",
            AutoTrackingConfiguration.SBand => "sBand",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoTrackingConfiguration value.")
        };

        public static AutoTrackingConfiguration ToAutoTrackingConfiguration(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "disabled")) return AutoTrackingConfiguration.Disabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "xBand")) return AutoTrackingConfiguration.XBand;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "sBand")) return AutoTrackingConfiguration.SBand;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoTrackingConfiguration value.");
        }
    }
}