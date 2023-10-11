// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VirtualMachineScaleSetVmExtensionsListResult
    {
        internal static VirtualMachineScaleSetVmExtensionsListResult DeserializeVirtualMachineScaleSetVmExtensionsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<VirtualMachineScaleSetVmExtensionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetVmExtensionData> array = new List<VirtualMachineScaleSetVmExtensionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineScaleSetVmExtensionData.DeserializeVirtualMachineScaleSetVmExtensionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetVmExtensionsListResult(Optional.ToList(value));
        }
    }
}