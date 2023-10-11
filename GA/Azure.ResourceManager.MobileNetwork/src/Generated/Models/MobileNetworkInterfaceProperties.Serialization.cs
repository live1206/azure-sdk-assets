// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkInterfaceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
            }
            if (Optional.IsDefined(IPv4Subnet))
            {
                writer.WritePropertyName("ipv4Subnet"u8);
                writer.WriteStringValue(IPv4Subnet);
            }
            if (Optional.IsDefined(IPv4Gateway))
            {
                writer.WritePropertyName("ipv4Gateway"u8);
                writer.WriteStringValue(IPv4Gateway);
            }
            writer.WriteEndObject();
        }

        internal static MobileNetworkInterfaceProperties DeserializeMobileNetworkInterfaceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> ipv4Address = default;
            Optional<string> ipv4Subnet = default;
            Optional<string> ipv4Gateway = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Subnet"u8))
                {
                    ipv4Subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Gateway"u8))
                {
                    ipv4Gateway = property.Value.GetString();
                    continue;
                }
            }
            return new MobileNetworkInterfaceProperties(name.Value, ipv4Address.Value, ipv4Subnet.Value, ipv4Gateway.Value);
        }
    }
}