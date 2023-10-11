// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class IPAddressPool : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("addresses"u8);
            writer.WriteStartArray();
            foreach (var item in Addresses)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(AutoAssign))
            {
                writer.WritePropertyName("autoAssign"u8);
                writer.WriteStringValue(AutoAssign.Value.ToString());
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(OnlyUseHostIPs))
            {
                writer.WritePropertyName("onlyUseHostIps"u8);
                writer.WriteStringValue(OnlyUseHostIPs.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static IPAddressPool DeserializeIPAddressPool(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> addresses = default;
            Optional<BfdEnabled> autoAssign = default;
            string name = default;
            Optional<BfdEnabled> onlyUseHostIPs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addresses"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addresses = array;
                    continue;
                }
                if (property.NameEquals("autoAssign"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoAssign = new BfdEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onlyUseHostIps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlyUseHostIPs = new BfdEnabled(property.Value.GetString());
                    continue;
                }
            }
            return new IPAddressPool(addresses, Optional.ToNullable(autoAssign), name, Optional.ToNullable(onlyUseHostIPs));
        }
    }
}