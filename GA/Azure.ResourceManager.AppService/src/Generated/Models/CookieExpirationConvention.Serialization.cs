// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class CookieExpirationConventionExtensions
    {
        public static string ToSerialString(this CookieExpirationConvention value) => value switch
        {
            CookieExpirationConvention.FixedTime => "FixedTime",
            CookieExpirationConvention.IdentityProviderDerived => "IdentityProviderDerived",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CookieExpirationConvention value.")
        };

        public static CookieExpirationConvention ToCookieExpirationConvention(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "FixedTime")) return CookieExpirationConvention.FixedTime;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IdentityProviderDerived")) return CookieExpirationConvention.IdentityProviderDerived;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CookieExpirationConvention value.");
        }
    }
}