// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchNameUnavailableReasonExtensions
    {
        public static string ToSerialString(this BatchNameUnavailableReason value) => value switch
        {
            BatchNameUnavailableReason.Invalid => "Invalid",
            BatchNameUnavailableReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchNameUnavailableReason value.")
        };

        public static BatchNameUnavailableReason ToBatchNameUnavailableReason(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Invalid")) return BatchNameUnavailableReason.Invalid;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AlreadyExists")) return BatchNameUnavailableReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchNameUnavailableReason value.");
        }
    }
}