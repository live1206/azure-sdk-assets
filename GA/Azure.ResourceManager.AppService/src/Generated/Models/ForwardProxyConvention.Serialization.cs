// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class ForwardProxyConventionExtensions
    {
        public static string ToSerialString(this ForwardProxyConvention value) => value switch
        {
            ForwardProxyConvention.NoProxy => "NoProxy",
            ForwardProxyConvention.Standard => "Standard",
            ForwardProxyConvention.Custom => "Custom",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ForwardProxyConvention value.")
        };

        public static ForwardProxyConvention ToForwardProxyConvention(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NoProxy")) return ForwardProxyConvention.NoProxy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard")) return ForwardProxyConvention.Standard;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Custom")) return ForwardProxyConvention.Custom;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ForwardProxyConvention value.");
        }
    }
}