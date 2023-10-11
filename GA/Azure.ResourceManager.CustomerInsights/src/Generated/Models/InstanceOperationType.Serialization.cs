// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    internal static partial class InstanceOperationTypeExtensions
    {
        public static string ToSerialString(this InstanceOperationType value) => value switch
        {
            InstanceOperationType.Upsert => "Upsert",
            InstanceOperationType.Delete => "Delete",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InstanceOperationType value.")
        };

        public static InstanceOperationType ToInstanceOperationType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Upsert")) return InstanceOperationType.Upsert;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Delete")) return InstanceOperationType.Delete;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InstanceOperationType value.");
        }
    }
}