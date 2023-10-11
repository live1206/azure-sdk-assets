// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationEnabledResourceType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterExtensionId))
            {
                writer.WritePropertyName("clusterExtensionId"u8);
                writer.WriteStringValue(ClusterExtensionId);
            }
            if (Optional.IsDefined(ExtensionType))
            {
                writer.WritePropertyName("extensionType"u8);
                writer.WriteStringValue(ExtensionType);
            }
            if (Optional.IsCollectionDefined(TypesMetadata))
            {
                writer.WritePropertyName("typesMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in TypesMetadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomLocationEnabledResourceType DeserializeCustomLocationEnabledResourceType(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> clusterExtensionId = default;
            Optional<string> extensionType = default;
            Optional<IList<CustomLocationEnabledResourceTypeMetadata>> typesMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterExtensionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterExtensionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extensionType"u8))
                        {
                            extensionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typesMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CustomLocationEnabledResourceTypeMetadata> array = new List<CustomLocationEnabledResourceTypeMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CustomLocationEnabledResourceTypeMetadata.DeserializeCustomLocationEnabledResourceTypeMetadata(item));
                            }
                            typesMetadata = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomLocationEnabledResourceType(id, name, type, systemData.Value, clusterExtensionId.Value, extensionType.Value, Optional.ToList(typesMetadata));
        }
    }
}