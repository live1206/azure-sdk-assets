// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult
    {
        internal static SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> array = new List<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint.DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(Optional.ToList(value));
        }
    }
}