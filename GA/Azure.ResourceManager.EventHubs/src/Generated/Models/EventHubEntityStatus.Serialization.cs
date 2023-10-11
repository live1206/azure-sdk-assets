// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal static partial class EventHubEntityStatusExtensions
    {
        public static string ToSerialString(this EventHubEntityStatus value) => value switch
        {
            EventHubEntityStatus.Unknown => "Unknown",
            EventHubEntityStatus.Active => "Active",
            EventHubEntityStatus.Disabled => "Disabled",
            EventHubEntityStatus.Restoring => "Restoring",
            EventHubEntityStatus.SendDisabled => "SendDisabled",
            EventHubEntityStatus.ReceiveDisabled => "ReceiveDisabled",
            EventHubEntityStatus.Creating => "Creating",
            EventHubEntityStatus.Deleting => "Deleting",
            EventHubEntityStatus.Renaming => "Renaming",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EventHubEntityStatus value.")
        };

        public static EventHubEntityStatus ToEventHubEntityStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unknown")) return EventHubEntityStatus.Unknown;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Active")) return EventHubEntityStatus.Active;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Disabled")) return EventHubEntityStatus.Disabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Restoring")) return EventHubEntityStatus.Restoring;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SendDisabled")) return EventHubEntityStatus.SendDisabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReceiveDisabled")) return EventHubEntityStatus.ReceiveDisabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Creating")) return EventHubEntityStatus.Creating;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Deleting")) return EventHubEntityStatus.Deleting;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Renaming")) return EventHubEntityStatus.Renaming;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EventHubEntityStatus value.");
        }
    }
}