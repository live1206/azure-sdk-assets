// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    internal partial class NeighborGroupsListResult
    {
        internal static NeighborGroupsListResult DeserializeNeighborGroupsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NetworkFabricNeighborGroupData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkFabricNeighborGroupData> array = new List<NetworkFabricNeighborGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkFabricNeighborGroupData.DeserializeNetworkFabricNeighborGroupData(item));
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
            return new NeighborGroupsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}