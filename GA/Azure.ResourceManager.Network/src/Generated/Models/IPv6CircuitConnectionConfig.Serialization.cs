// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IPv6CircuitConnectionConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            writer.WriteEndObject();
        }

        internal static IPv6CircuitConnectionConfig DeserializeIPv6CircuitConnectionConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressPrefix = default;
            Optional<CircuitConnectionStatus> circuitConnectionStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("circuitConnectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    circuitConnectionStatus = new CircuitConnectionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new IPv6CircuitConnectionConfig(addressPrefix.Value, Optional.ToNullable(circuitConnectionStatus));
        }
    }
}
