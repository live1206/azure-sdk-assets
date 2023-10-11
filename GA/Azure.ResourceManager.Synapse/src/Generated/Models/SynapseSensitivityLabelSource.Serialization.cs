// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SynapseSensitivityLabelSourceExtensions
    {
        public static string ToSerialString(this SynapseSensitivityLabelSource value) => value switch
        {
            SynapseSensitivityLabelSource.Current => "current",
            SynapseSensitivityLabelSource.Recommended => "recommended",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelSource value.")
        };

        public static SynapseSensitivityLabelSource ToSynapseSensitivityLabelSource(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "current")) return SynapseSensitivityLabelSource.Current;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "recommended")) return SynapseSensitivityLabelSource.Recommended;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelSource value.");
        }
    }
}