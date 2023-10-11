// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class BastionHostPropertiesFormatNetworkAcls : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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

        internal static BastionHostPropertiesFormatNetworkAcls DeserializeBastionHostPropertiesFormatNetworkAcls(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BastionHostIPRule>> ipRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BastionHostIPRule> array = new List<BastionHostIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BastionHostIPRule.DeserializeBastionHostIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
            }
            return new BastionHostPropertiesFormatNetworkAcls(Optional.ToList(ipRules));
        }
    }
}