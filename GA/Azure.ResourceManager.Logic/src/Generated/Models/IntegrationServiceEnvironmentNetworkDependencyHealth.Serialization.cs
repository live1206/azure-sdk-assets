// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentNetworkDependencyHealth
    {
        internal static IntegrationServiceEnvironmentNetworkDependencyHealth DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationServiceErrorInfo> error = default;
            Optional<IntegrationServiceEnvironmentNetworkDependencyHealthState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = IntegrationServiceErrorInfo.DeserializeIntegrationServiceErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationServiceEnvironmentNetworkDependencyHealthState(property.Value.GetString());
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentNetworkDependencyHealth(error.Value, Optional.ToNullable(state));
        }
    }
}
