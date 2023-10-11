// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppVolumeQuotaRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(QuotaSizeInKiBs))
            {
                writer.WritePropertyName("quotaSizeInKiBs"u8);
                writer.WriteNumberValue(QuotaSizeInKiBs.Value);
            }
            if (Optional.IsDefined(QuotaType))
            {
                writer.WritePropertyName("quotaType"u8);
                writer.WriteStringValue(QuotaType.Value.ToString());
            }
            if (Optional.IsDefined(QuotaTarget))
            {
                writer.WritePropertyName("quotaTarget"u8);
                writer.WriteStringValue(QuotaTarget);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetAppVolumeQuotaRuleData DeserializeNetAppVolumeQuotaRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NetAppProvisioningState> provisioningState = default;
            Optional<long> quotaSizeInKiBs = default;
            Optional<NetAppVolumeQuotaType> quotaType = default;
            Optional<string> quotaTarget = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToNetAppProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("quotaSizeInKiBs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quotaSizeInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("quotaType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quotaType = new NetAppVolumeQuotaType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("quotaTarget"u8))
                        {
                            quotaTarget = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppVolumeQuotaRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(quotaSizeInKiBs), Optional.ToNullable(quotaType), quotaTarget.Value);
        }
    }
}