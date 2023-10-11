// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class PrivateEndpointConnectionForPrivateLinkHubBasic
    {
        internal static PrivateEndpointConnectionForPrivateLinkHubBasic DeserializePrivateEndpointConnectionForPrivateLinkHubBasic(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<SynapsePrivateEndpointConnectionProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SynapsePrivateEndpointConnectionProperties.DeserializeSynapsePrivateEndpointConnectionProperties(property.Value);
                    continue;
                }
            }
            return new PrivateEndpointConnectionForPrivateLinkHubBasic(id.Value, properties.Value);
        }
    }
}
