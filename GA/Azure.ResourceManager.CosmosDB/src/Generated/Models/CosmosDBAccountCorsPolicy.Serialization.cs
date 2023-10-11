// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountCorsPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allowedOrigins"u8);
            writer.WriteStringValue(AllowedOrigins);
            if (Optional.IsDefined(AllowedMethods))
            {
                writer.WritePropertyName("allowedMethods"u8);
                writer.WriteStringValue(AllowedMethods);
            }
            if (Optional.IsDefined(AllowedHeaders))
            {
                writer.WritePropertyName("allowedHeaders"u8);
                writer.WriteStringValue(AllowedHeaders);
            }
            if (Optional.IsDefined(ExposedHeaders))
            {
                writer.WritePropertyName("exposedHeaders"u8);
                writer.WriteStringValue(ExposedHeaders);
            }
            if (Optional.IsDefined(MaxAgeInSeconds))
            {
                writer.WritePropertyName("maxAgeInSeconds"u8);
                writer.WriteNumberValue(MaxAgeInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBAccountCorsPolicy DeserializeCosmosDBAccountCorsPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string allowedOrigins = default;
            Optional<string> allowedMethods = default;
            Optional<string> allowedHeaders = default;
            Optional<string> exposedHeaders = default;
            Optional<long> maxAgeInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"u8))
                {
                    allowedOrigins = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedMethods"u8))
                {
                    allowedMethods = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedHeaders"u8))
                {
                    allowedHeaders = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exposedHeaders"u8))
                {
                    exposedHeaders = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxAgeInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAgeInSeconds = property.Value.GetInt64();
                    continue;
                }
            }
            return new CosmosDBAccountCorsPolicy(allowedOrigins, allowedMethods.Value, allowedHeaders.Value, exposedHeaders.Value, Optional.ToNullable(maxAgeInSeconds));
        }
    }
}