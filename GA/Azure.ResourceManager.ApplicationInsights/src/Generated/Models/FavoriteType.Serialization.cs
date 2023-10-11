// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    internal static partial class FavoriteTypeExtensions
    {
        public static string ToSerialString(this FavoriteType value) => value switch
        {
            FavoriteType.Shared => "shared",
            FavoriteType.User => "user",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FavoriteType value.")
        };

        public static FavoriteType ToFavoriteType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "shared")) return FavoriteType.Shared;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "user")) return FavoriteType.User;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FavoriteType value.");
        }
    }
}