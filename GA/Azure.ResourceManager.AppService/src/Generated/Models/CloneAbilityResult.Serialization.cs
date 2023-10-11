// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class CloneAbilityResultExtensions
    {
        public static string ToSerialString(this CloneAbilityResult value) => value switch
        {
            CloneAbilityResult.Cloneable => "Cloneable",
            CloneAbilityResult.PartiallyCloneable => "PartiallyCloneable",
            CloneAbilityResult.NotCloneable => "NotCloneable",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CloneAbilityResult value.")
        };

        public static CloneAbilityResult ToCloneAbilityResult(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Cloneable")) return CloneAbilityResult.Cloneable;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PartiallyCloneable")) return CloneAbilityResult.PartiallyCloneable;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotCloneable")) return CloneAbilityResult.NotCloneable;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CloneAbilityResult value.");
        }
    }
}