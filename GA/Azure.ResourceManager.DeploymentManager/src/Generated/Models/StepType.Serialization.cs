// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    internal static partial class StepTypeExtensions
    {
        public static string ToSerialString(this StepType value) => value switch
        {
            StepType.Wait => "Wait",
            StepType.HealthCheck => "HealthCheck",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StepType value.")
        };

        public static StepType ToStepType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Wait")) return StepType.Wait;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "HealthCheck")) return StepType.HealthCheck;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StepType value.");
        }
    }
}