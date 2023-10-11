// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class SpendingLimitExtensions
    {
        public static string ToSerialString(this SpendingLimit value) => value switch
        {
            SpendingLimit.On => "On",
            SpendingLimit.Off => "Off",
            SpendingLimit.CurrentPeriodOff => "CurrentPeriodOff",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SpendingLimit value.")
        };

        public static SpendingLimit ToSpendingLimit(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "On")) return SpendingLimit.On;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Off")) return SpendingLimit.Off;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CurrentPeriodOff")) return SpendingLimit.CurrentPeriodOff;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SpendingLimit value.");
        }
    }
}
