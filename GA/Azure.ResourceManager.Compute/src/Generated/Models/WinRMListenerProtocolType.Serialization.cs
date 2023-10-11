// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class WinRMListenerProtocolTypeExtensions
    {
        public static string ToSerialString(this WinRMListenerProtocolType value) => value switch
        {
            WinRMListenerProtocolType.Http => "Http",
            WinRMListenerProtocolType.Https => "Https",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WinRMListenerProtocolType value.")
        };

        public static WinRMListenerProtocolType ToWinRMListenerProtocolType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Http")) return WinRMListenerProtocolType.Http;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Https")) return WinRMListenerProtocolType.Https;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WinRMListenerProtocolType value.");
        }
    }
}