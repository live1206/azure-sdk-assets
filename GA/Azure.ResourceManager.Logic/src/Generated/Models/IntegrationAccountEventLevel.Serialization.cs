// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    internal static partial class IntegrationAccountEventLevelExtensions
    {
        public static string ToSerialString(this IntegrationAccountEventLevel value) => value switch
        {
            IntegrationAccountEventLevel.LogAlways => "LogAlways",
            IntegrationAccountEventLevel.Critical => "Critical",
            IntegrationAccountEventLevel.Error => "Error",
            IntegrationAccountEventLevel.Warning => "Warning",
            IntegrationAccountEventLevel.Informational => "Informational",
            IntegrationAccountEventLevel.Verbose => "Verbose",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IntegrationAccountEventLevel value.")
        };

        public static IntegrationAccountEventLevel ToIntegrationAccountEventLevel(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LogAlways")) return IntegrationAccountEventLevel.LogAlways;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Critical")) return IntegrationAccountEventLevel.Critical;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Error")) return IntegrationAccountEventLevel.Error;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Warning")) return IntegrationAccountEventLevel.Warning;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Informational")) return IntegrationAccountEventLevel.Informational;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Verbose")) return IntegrationAccountEventLevel.Verbose;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IntegrationAccountEventLevel value.");
        }
    }
}
