// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkConfigurationDiagnosticProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            writer.WritePropertyName("destination"u8);
            writer.WriteStringValue(Destination);
            writer.WritePropertyName("destinationPort"u8);
            writer.WriteStringValue(DestinationPort);
            writer.WriteEndObject();
        }

        internal static NetworkConfigurationDiagnosticProfile DeserializeNetworkConfigurationDiagnosticProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkTrafficDirection direction = default;
            string protocol = default;
            string source = default;
            string destination = default;
            string destinationPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("direction"u8))
                {
                    direction = new NetworkTrafficDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"u8))
                {
                    destinationPort = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkConfigurationDiagnosticProfile(direction, protocol, source, destination, destinationPort);
        }
    }
}
