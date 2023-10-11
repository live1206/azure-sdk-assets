// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class DedicatedHostAvailableCapacity
    {
        internal static DedicatedHostAvailableCapacity DeserializeDedicatedHostAvailableCapacity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DedicatedHostAllocatableVm>> allocatableVms = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocatableVMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DedicatedHostAllocatableVm> array = new List<DedicatedHostAllocatableVm>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHostAllocatableVm.DeserializeDedicatedHostAllocatableVm(item));
                    }
                    allocatableVms = array;
                    continue;
                }
            }
            return new DedicatedHostAvailableCapacity(Optional.ToList(allocatableVms));
        }
    }
}