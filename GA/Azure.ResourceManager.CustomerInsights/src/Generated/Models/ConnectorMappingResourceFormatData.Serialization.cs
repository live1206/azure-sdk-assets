// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class ConnectorMappingResourceFormatData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectorType))
            {
                writer.WritePropertyName("connectorType"u8);
                writer.WriteStringValue(ConnectorType.Value.ToString());
            }
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType.Value.ToSerialString());
            }
            if (Optional.IsDefined(EntityTypeName))
            {
                writer.WritePropertyName("entityTypeName"u8);
                writer.WriteStringValue(EntityTypeName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(MappingProperties))
            {
                writer.WritePropertyName("mappingProperties"u8);
                writer.WriteObjectValue(MappingProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConnectorMappingResourceFormatData DeserializeConnectorMappingResourceFormatData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> connectorName = default;
            Optional<ConnectorType> connectorType = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<EntityType> entityType = default;
            Optional<string> entityTypeName = default;
            Optional<string> connectorMappingName = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> dataFormatId = default;
            Optional<ConnectorMappingProperties> mappingProperties = default;
            Optional<DateTimeOffset> nextRunTime = default;
            Optional<string> runId = default;
            Optional<ConnectorMappingState> state = default;
            Optional<Guid> tenantId = default;
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
                        if (property0.NameEquals("connectorName"u8))
                        {
                            connectorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectorType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectorType = new ConnectorType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("entityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            entityType = property0.Value.GetString().ToEntityType();
                            continue;
                        }
                        if (property0.NameEquals("entityTypeName"u8))
                        {
                            entityTypeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectorMappingName"u8))
                        {
                            connectorMappingName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataFormatId"u8))
                        {
                            dataFormatId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mappingProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mappingProperties = ConnectorMappingProperties.DeserializeConnectorMappingProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("nextRunTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextRunTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("runId"u8))
                        {
                            runId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToConnectorMappingState();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectorMappingResourceFormatData(id, name, type, systemData.Value, connectorName.Value, Optional.ToNullable(connectorType), Optional.ToNullable(created), Optional.ToNullable(lastModified), Optional.ToNullable(entityType), entityTypeName.Value, connectorMappingName.Value, displayName.Value, description.Value, dataFormatId.Value, mappingProperties.Value, Optional.ToNullable(nextRunTime), runId.Value, Optional.ToNullable(state), Optional.ToNullable(tenantId));
        }
    }
}