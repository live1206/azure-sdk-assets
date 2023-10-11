// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DiagnosticRemoteSupportSettingData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RemoteSupportSettingsList))
            {
                writer.WritePropertyName("remoteSupportSettingsList"u8);
                writer.WriteStartArray();
                foreach (var item in RemoteSupportSettingsList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiagnosticRemoteSupportSettingData DeserializeDiagnosticRemoteSupportSettingData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<EdgeRemoteSupportSettings>> remoteSupportSettingsList = default;
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
                        if (property0.NameEquals("remoteSupportSettingsList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EdgeRemoteSupportSettings> array = new List<EdgeRemoteSupportSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EdgeRemoteSupportSettings.DeserializeEdgeRemoteSupportSettings(item));
                            }
                            remoteSupportSettingsList = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiagnosticRemoteSupportSettingData(id, name, type, systemData.Value, Optional.ToList(remoteSupportSettingsList));
        }
    }
}
