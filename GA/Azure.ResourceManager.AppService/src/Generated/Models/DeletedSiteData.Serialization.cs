// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class DeletedSiteData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeletedSiteData DeserializeDeletedSiteData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> deletedSiteId = default;
            Optional<string> deletedTimestamp = default;
            Optional<string> subscription = default;
            Optional<string> resourceGroup = default;
            Optional<string> deletedSiteName = default;
            Optional<string> slot = default;
            Optional<string> kind0 = default;
            Optional<string> geoRegionName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("deletedSiteId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deletedSiteId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("deletedTimestamp"u8))
                        {
                            deletedTimestamp = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscription"u8))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deletedSiteName"u8))
                        {
                            deletedSiteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("slot"u8))
                        {
                            slot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kind"u8))
                        {
                            kind0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geoRegionName"u8))
                        {
                            geoRegionName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeletedSiteData(id, name, type, systemData.Value, Optional.ToNullable(deletedSiteId), deletedTimestamp.Value, subscription.Value, resourceGroup.Value, deletedSiteName.Value, slot.Value, kind0.Value, geoRegionName.Value, kind.Value);
        }
    }
}