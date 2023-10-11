// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    internal static partial class LabUserInvitationStateExtensions
    {
        public static string ToSerialString(this LabUserInvitationState value) => value switch
        {
            LabUserInvitationState.NotSent => "NotSent",
            LabUserInvitationState.Sending => "Sending",
            LabUserInvitationState.Sent => "Sent",
            LabUserInvitationState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabUserInvitationState value.")
        };

        public static LabUserInvitationState ToLabUserInvitationState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSent")) return LabUserInvitationState.NotSent;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sending")) return LabUserInvitationState.Sending;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sent")) return LabUserInvitationState.Sent;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return LabUserInvitationState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabUserInvitationState value.");
        }
    }
}