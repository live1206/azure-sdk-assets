// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Search.Models
{
    internal static partial class SearchAadAuthFailureModeExtensions
    {
        public static string ToSerialString(this SearchAadAuthFailureMode value) => value switch
        {
            SearchAadAuthFailureMode.Http403 => "http403",
            SearchAadAuthFailureMode.Http401WithBearerChallenge => "http401WithBearerChallenge",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchAadAuthFailureMode value.")
        };

        public static SearchAadAuthFailureMode ToSearchAadAuthFailureMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "http403")) return SearchAadAuthFailureMode.Http403;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "http401WithBearerChallenge")) return SearchAadAuthFailureMode.Http401WithBearerChallenge;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchAadAuthFailureMode value.");
        }
    }
}