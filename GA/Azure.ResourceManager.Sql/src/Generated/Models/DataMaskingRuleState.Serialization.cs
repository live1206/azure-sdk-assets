// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class DataMaskingRuleStateExtensions
    {
        public static string ToSerialString(this DataMaskingRuleState value) => value switch
        {
            DataMaskingRuleState.Disabled => "Disabled",
            DataMaskingRuleState.Enabled => "Enabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataMaskingRuleState value.")
        };

        public static DataMaskingRuleState ToDataMaskingRuleState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Disabled")) return DataMaskingRuleState.Disabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Enabled")) return DataMaskingRuleState.Enabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataMaskingRuleState value.");
        }
    }
}