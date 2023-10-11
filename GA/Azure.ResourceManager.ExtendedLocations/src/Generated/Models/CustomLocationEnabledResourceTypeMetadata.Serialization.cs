// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationEnabledResourceTypeMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(ResourceProviderNamespace))
            {
                writer.WritePropertyName("resourceProviderNamespace"u8);
                writer.WriteStringValue(ResourceProviderNamespace);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            writer.WriteEndObject();
        }

        internal static CustomLocationEnabledResourceTypeMetadata DeserializeCustomLocationEnabledResourceTypeMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiVersion = default;
            Optional<string> resourceProviderNamespace = default;
            Optional<string> resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProviderNamespace"u8))
                {
                    resourceProviderNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new CustomLocationEnabledResourceTypeMetadata(apiVersion.Value, resourceProviderNamespace.Value, resourceType.Value);
        }
    }
}