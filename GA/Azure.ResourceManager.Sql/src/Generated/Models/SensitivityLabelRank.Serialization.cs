// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class SensitivityLabelRankExtensions
    {
        public static string ToSerialString(this SensitivityLabelRank value) => value switch
        {
            SensitivityLabelRank.None => "None",
            SensitivityLabelRank.Low => "Low",
            SensitivityLabelRank.Medium => "Medium",
            SensitivityLabelRank.High => "High",
            SensitivityLabelRank.Critical => "Critical",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SensitivityLabelRank value.")
        };

        public static SensitivityLabelRank ToSensitivityLabelRank(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return SensitivityLabelRank.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Low")) return SensitivityLabelRank.Low;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Medium")) return SensitivityLabelRank.Medium;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "High")) return SensitivityLabelRank.High;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Critical")) return SensitivityLabelRank.Critical;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SensitivityLabelRank value.");
        }
    }
}