// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal static partial class DataLakeStoreUsageUnitExtensions
    {
        public static string ToSerialString(this DataLakeStoreUsageUnit value) => value switch
        {
            DataLakeStoreUsageUnit.Count => "Count",
            DataLakeStoreUsageUnit.Bytes => "Bytes",
            DataLakeStoreUsageUnit.Seconds => "Seconds",
            DataLakeStoreUsageUnit.Percent => "Percent",
            DataLakeStoreUsageUnit.CountsPerSecond => "CountsPerSecond",
            DataLakeStoreUsageUnit.BytesPerSecond => "BytesPerSecond",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreUsageUnit value.")
        };

        public static DataLakeStoreUsageUnit ToDataLakeStoreUsageUnit(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Count")) return DataLakeStoreUsageUnit.Count;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Bytes")) return DataLakeStoreUsageUnit.Bytes;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Seconds")) return DataLakeStoreUsageUnit.Seconds;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Percent")) return DataLakeStoreUsageUnit.Percent;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CountsPerSecond")) return DataLakeStoreUsageUnit.CountsPerSecond;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "BytesPerSecond")) return DataLakeStoreUsageUnit.BytesPerSecond;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreUsageUnit value.");
        }
    }
}