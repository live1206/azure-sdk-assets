// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchWindowsLoginModeExtensions
    {
        public static string ToSerialString(this BatchWindowsLoginMode value) => value switch
        {
            BatchWindowsLoginMode.Batch => "Batch",
            BatchWindowsLoginMode.Interactive => "Interactive",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchWindowsLoginMode value.")
        };

        public static BatchWindowsLoginMode ToBatchWindowsLoginMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Batch")) return BatchWindowsLoginMode.Batch;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Interactive")) return BatchWindowsLoginMode.Interactive;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchWindowsLoginMode value.");
        }
    }
}