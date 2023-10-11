// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    internal static partial class PostgreSqlFlexbileServerCapabilityStatusExtensions
    {
        public static string ToSerialString(this PostgreSqlFlexbileServerCapabilityStatus value) => value switch
        {
            PostgreSqlFlexbileServerCapabilityStatus.Visible => "Visible",
            PostgreSqlFlexbileServerCapabilityStatus.Available => "Available",
            PostgreSqlFlexbileServerCapabilityStatus.Default => "Default",
            PostgreSqlFlexbileServerCapabilityStatus.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PostgreSqlFlexbileServerCapabilityStatus value.")
        };

        public static PostgreSqlFlexbileServerCapabilityStatus ToPostgreSqlFlexbileServerCapabilityStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Visible")) return PostgreSqlFlexbileServerCapabilityStatus.Visible;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Available")) return PostgreSqlFlexbileServerCapabilityStatus.Available;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Default")) return PostgreSqlFlexbileServerCapabilityStatus.Default;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Disabled")) return PostgreSqlFlexbileServerCapabilityStatus.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PostgreSqlFlexbileServerCapabilityStatus value.");
        }
    }
}