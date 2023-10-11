// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    internal static partial class LabVirtualMachineConnectionTypeExtensions
    {
        public static string ToSerialString(this LabVirtualMachineConnectionType value) => value switch
        {
            LabVirtualMachineConnectionType.None => "None",
            LabVirtualMachineConnectionType.Public => "Public",
            LabVirtualMachineConnectionType.Private => "Private",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabVirtualMachineConnectionType value.")
        };

        public static LabVirtualMachineConnectionType ToLabVirtualMachineConnectionType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return LabVirtualMachineConnectionType.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Public")) return LabVirtualMachineConnectionType.Public;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Private")) return LabVirtualMachineConnectionType.Private;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabVirtualMachineConnectionType value.");
        }
    }
}