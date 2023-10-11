// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class IntegrationServiceEnvironmentAccessEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static IntegrationServiceEnvironmentAccessEndpoint DeserializeIntegrationServiceEnvironmentAccessEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationServiceEnvironmentAccessEndpointType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new IntegrationServiceEnvironmentAccessEndpointType(property.Value.GetString());
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentAccessEndpoint(Optional.ToNullable(type));
        }
    }
}