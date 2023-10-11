// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    internal static partial class SegmentTerminatorSuffixExtensions
    {
        public static string ToSerialString(this SegmentTerminatorSuffix value) => value switch
        {
            SegmentTerminatorSuffix.None => "None",
            SegmentTerminatorSuffix.NotSpecified => "NotSpecified",
            SegmentTerminatorSuffix.CR => "CR",
            SegmentTerminatorSuffix.LF => "LF",
            SegmentTerminatorSuffix.Crlf => "CRLF",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SegmentTerminatorSuffix value.")
        };

        public static SegmentTerminatorSuffix ToSegmentTerminatorSuffix(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return SegmentTerminatorSuffix.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSpecified")) return SegmentTerminatorSuffix.NotSpecified;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CR")) return SegmentTerminatorSuffix.CR;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LF")) return SegmentTerminatorSuffix.LF;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CRLF")) return SegmentTerminatorSuffix.Crlf;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SegmentTerminatorSuffix value.");
        }
    }
}