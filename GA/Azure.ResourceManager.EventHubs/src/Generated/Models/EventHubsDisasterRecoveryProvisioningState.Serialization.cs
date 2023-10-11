// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal static partial class EventHubsDisasterRecoveryProvisioningStateExtensions
    {
        public static string ToSerialString(this EventHubsDisasterRecoveryProvisioningState value) => value switch
        {
            EventHubsDisasterRecoveryProvisioningState.Accepted => "Accepted",
            EventHubsDisasterRecoveryProvisioningState.Succeeded => "Succeeded",
            EventHubsDisasterRecoveryProvisioningState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EventHubsDisasterRecoveryProvisioningState value.")
        };

        public static EventHubsDisasterRecoveryProvisioningState ToEventHubsDisasterRecoveryProvisioningState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Accepted")) return EventHubsDisasterRecoveryProvisioningState.Accepted;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Succeeded")) return EventHubsDisasterRecoveryProvisioningState.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return EventHubsDisasterRecoveryProvisioningState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EventHubsDisasterRecoveryProvisioningState value.");
        }
    }
}