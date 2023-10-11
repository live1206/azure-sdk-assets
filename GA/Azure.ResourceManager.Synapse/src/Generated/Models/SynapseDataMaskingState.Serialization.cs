// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SynapseDataMaskingStateExtensions
    {
        public static string ToSerialString(this SynapseDataMaskingState value) => value switch
        {
            SynapseDataMaskingState.Disabled => "Disabled",
            SynapseDataMaskingState.Enabled => "Enabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseDataMaskingState value.")
        };

        public static SynapseDataMaskingState ToSynapseDataMaskingState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Disabled")) return SynapseDataMaskingState.Disabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Enabled")) return SynapseDataMaskingState.Enabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseDataMaskingState value.");
        }
    }
}
