// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    public partial class IPv6FirewallRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartIPv6Address))
            {
                writer.WritePropertyName("startIPv6Address"u8);
                writer.WriteStringValue(StartIPv6Address);
            }
            if (Optional.IsDefined(EndIPv6Address))
            {
                writer.WritePropertyName("endIPv6Address"u8);
                writer.WriteStringValue(EndIPv6Address);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IPv6FirewallRuleData DeserializeIPv6FirewallRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<string> startIPv6Address = default;
            Optional<string> endIPv6Address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                        if (property0.NameEquals("startIPv6Address"u8))
                        {
                            startIPv6Address = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endIPv6Address"u8))
                        {
                            endIPv6Address = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IPv6FirewallRuleData(id.Value, name.Value, Optional.ToNullable(type), startIPv6Address.Value, endIPv6Address.Value);
        }
    }
}