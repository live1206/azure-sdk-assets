// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightPrivateLinkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("groupId"u8);
            writer.WriteStringValue(GroupId);
            writer.WritePropertyName("ipConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in IPConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HDInsightPrivateLinkConfiguration DeserializeHDInsightPrivateLinkConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            string name = default;
            Optional<ResourceType> type = default;
            string groupId = default;
            Optional<HDInsightPrivateLinkConfigurationProvisioningState> provisioningState = default;
            IList<HDInsightIPConfiguration> ipConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("groupId"u8))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HDInsightPrivateLinkConfigurationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            List<HDInsightIPConfiguration> array = new List<HDInsightIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HDInsightIPConfiguration.DeserializeHDInsightIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HDInsightPrivateLinkConfiguration(id.Value, name, Optional.ToNullable(type), groupId, Optional.ToNullable(provisioningState), ipConfigurations);
        }
    }
}