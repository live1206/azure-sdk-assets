// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class ManagedPipelineModeExtensions
    {
        public static string ToSerialString(this ManagedPipelineMode value) => value switch
        {
            ManagedPipelineMode.Integrated => "Integrated",
            ManagedPipelineMode.Classic => "Classic",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagedPipelineMode value.")
        };

        public static ManagedPipelineMode ToManagedPipelineMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Integrated")) return ManagedPipelineMode.Integrated;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Classic")) return ManagedPipelineMode.Classic;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagedPipelineMode value.");
        }
    }
}