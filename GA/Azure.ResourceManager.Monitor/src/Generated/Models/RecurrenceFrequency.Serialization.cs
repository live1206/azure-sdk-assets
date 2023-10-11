// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    internal static partial class RecurrenceFrequencyExtensions
    {
        public static string ToSerialString(this RecurrenceFrequency value) => value switch
        {
            RecurrenceFrequency.None => "None",
            RecurrenceFrequency.Second => "Second",
            RecurrenceFrequency.Minute => "Minute",
            RecurrenceFrequency.Hour => "Hour",
            RecurrenceFrequency.Day => "Day",
            RecurrenceFrequency.Week => "Week",
            RecurrenceFrequency.Month => "Month",
            RecurrenceFrequency.Year => "Year",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecurrenceFrequency value.")
        };

        public static RecurrenceFrequency ToRecurrenceFrequency(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return RecurrenceFrequency.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Second")) return RecurrenceFrequency.Second;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Minute")) return RecurrenceFrequency.Minute;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Hour")) return RecurrenceFrequency.Hour;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Day")) return RecurrenceFrequency.Day;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Week")) return RecurrenceFrequency.Week;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Month")) return RecurrenceFrequency.Month;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Year")) return RecurrenceFrequency.Year;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecurrenceFrequency value.");
        }
    }
}