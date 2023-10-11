// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralNetworkRuleSets : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ApplyToDevices))
            {
                writer.WritePropertyName("applyToDevices"u8);
                writer.WriteBooleanValue(ApplyToDevices.Value);
            }
            if (Optional.IsDefined(ApplyToIotCentral))
            {
                writer.WritePropertyName("applyToIoTCentral"u8);
                writer.WriteBooleanValue(ApplyToIotCentral.Value);
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IotCentralNetworkRuleSets DeserializeIotCentralNetworkRuleSets(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> applyToDevices = default;
            Optional<bool> applyToIoTCentral = default;
            Optional<IotCentralNetworkAction> defaultAction = default;
            Optional<IList<IotCentralNetworkRuleSetIPRule>> ipRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applyToDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applyToDevices = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("applyToIoTCentral"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applyToIoTCentral = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new IotCentralNetworkAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotCentralNetworkRuleSetIPRule> array = new List<IotCentralNetworkRuleSetIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralNetworkRuleSetIPRule.DeserializeIotCentralNetworkRuleSetIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
            }
            return new IotCentralNetworkRuleSets(Optional.ToNullable(applyToDevices), Optional.ToNullable(applyToIoTCentral), Optional.ToNullable(defaultAction), Optional.ToList(ipRules));
        }
    }
}
