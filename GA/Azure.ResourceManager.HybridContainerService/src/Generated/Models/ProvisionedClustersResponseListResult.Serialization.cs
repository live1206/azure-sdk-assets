// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class ProvisionedClustersResponseListResult
    {
        internal static ProvisionedClustersResponseListResult DeserializeProvisionedClustersResponseListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ProvisionedClusterData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProvisionedClusterData> array = new List<ProvisionedClusterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProvisionedClusterData.DeserializeProvisionedClusterData(item));
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
            return new ProvisionedClustersResponseListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}