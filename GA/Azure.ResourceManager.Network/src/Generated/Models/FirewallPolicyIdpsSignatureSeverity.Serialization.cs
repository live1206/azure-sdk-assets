// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    internal static partial class FirewallPolicyIdpsSignatureSeverityExtensions
    {
        public static FirewallPolicyIdpsSignatureSeverity ToFirewallPolicyIdpsSignatureSeverity(this int value)
        {
            if (value == 1) return FirewallPolicyIdpsSignatureSeverity.One;
            if (value == 2) return FirewallPolicyIdpsSignatureSeverity.Two;
            if (value == 3) return FirewallPolicyIdpsSignatureSeverity.Three;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FirewallPolicyIdpsSignatureSeverity value.");
        }
    }
}