// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class ApiProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerVersion))
            {
                writer.WritePropertyName("serverVersion"u8);
                writer.WriteStringValue(ServerVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ApiProperties DeserializeApiProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CosmosDBServerVersion> serverVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverVersion = new CosmosDBServerVersion(property.Value.GetString());
                    continue;
                }
            }
            return new ApiProperties(Optional.ToNullable(serverVersion));
        }
    }
}