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
    internal partial class AgentPoolListResult
    {
        internal static AgentPoolListResult DeserializeAgentPoolListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HybridContainerServiceAgentPoolData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridContainerServiceAgentPoolData> array = new List<HybridContainerServiceAgentPoolData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(item));
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
            return new AgentPoolListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}