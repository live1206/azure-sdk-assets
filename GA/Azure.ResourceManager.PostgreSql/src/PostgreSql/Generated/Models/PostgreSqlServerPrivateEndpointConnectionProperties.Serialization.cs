// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlServerPrivateEndpointConnectionProperties
    {
        internal static PostgreSqlServerPrivateEndpointConnectionProperties DeserializePostgreSqlServerPrivateEndpointConnectionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> privateEndpoint = default;
            Optional<PostgreSqlServerPrivateLinkServiceConnectionStateProperty> privateLinkServiceConnectionState = default;
            Optional<PostgreSqlPrivateEndpointProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = PostgreSqlServerPrivateLinkServiceConnectionStateProperty.DeserializePostgreSqlServerPrivateLinkServiceConnectionStateProperty(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PostgreSqlPrivateEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new PostgreSqlServerPrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState.Value, Optional.ToNullable(provisioningState));
        }
    }
}