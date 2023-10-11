// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class WorkloadNetworkPortMirroringList
    {
        internal static WorkloadNetworkPortMirroringList DeserializeWorkloadNetworkPortMirroringList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<WorkloadNetworkPortMirroringProfileData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkloadNetworkPortMirroringProfileData> array = new List<WorkloadNetworkPortMirroringProfileData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkloadNetworkPortMirroringProfileData.DeserializeWorkloadNetworkPortMirroringProfileData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new WorkloadNetworkPortMirroringList(Optional.ToList(value), nextLink.Value);
        }
    }
}