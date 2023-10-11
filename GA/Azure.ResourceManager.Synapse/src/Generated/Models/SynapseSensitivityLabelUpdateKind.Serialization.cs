// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SynapseSensitivityLabelUpdateKindExtensions
    {
        public static string ToSerialString(this SynapseSensitivityLabelUpdateKind value) => value switch
        {
            SynapseSensitivityLabelUpdateKind.Set => "set",
            SynapseSensitivityLabelUpdateKind.Remove => "remove",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelUpdateKind value.")
        };

        public static SynapseSensitivityLabelUpdateKind ToSynapseSensitivityLabelUpdateKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "set")) return SynapseSensitivityLabelUpdateKind.Set;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "remove")) return SynapseSensitivityLabelUpdateKind.Remove;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelUpdateKind value.");
        }
    }
}