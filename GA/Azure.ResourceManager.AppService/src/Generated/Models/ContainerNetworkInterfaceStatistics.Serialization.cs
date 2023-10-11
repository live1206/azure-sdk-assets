// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerNetworkInterfaceStatistics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RxBytes))
            {
                writer.WritePropertyName("rxBytes"u8);
                writer.WriteNumberValue(RxBytes.Value);
            }
            if (Optional.IsDefined(RxPackets))
            {
                writer.WritePropertyName("rxPackets"u8);
                writer.WriteNumberValue(RxPackets.Value);
            }
            if (Optional.IsDefined(RxErrors))
            {
                writer.WritePropertyName("rxErrors"u8);
                writer.WriteNumberValue(RxErrors.Value);
            }
            if (Optional.IsDefined(RxDropped))
            {
                writer.WritePropertyName("rxDropped"u8);
                writer.WriteNumberValue(RxDropped.Value);
            }
            if (Optional.IsDefined(TxBytes))
            {
                writer.WritePropertyName("txBytes"u8);
                writer.WriteNumberValue(TxBytes.Value);
            }
            if (Optional.IsDefined(TxPackets))
            {
                writer.WritePropertyName("txPackets"u8);
                writer.WriteNumberValue(TxPackets.Value);
            }
            if (Optional.IsDefined(TxErrors))
            {
                writer.WritePropertyName("txErrors"u8);
                writer.WriteNumberValue(TxErrors.Value);
            }
            if (Optional.IsDefined(TxDropped))
            {
                writer.WritePropertyName("txDropped"u8);
                writer.WriteNumberValue(TxDropped.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerNetworkInterfaceStatistics DeserializeContainerNetworkInterfaceStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> rxBytes = default;
            Optional<long> rxPackets = default;
            Optional<long> rxErrors = default;
            Optional<long> rxDropped = default;
            Optional<long> txBytes = default;
            Optional<long> txPackets = default;
            Optional<long> txErrors = default;
            Optional<long> txDropped = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rxBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rxPackets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxPackets = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rxErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxErrors = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rxDropped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rxDropped = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txPackets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txPackets = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txErrors = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("txDropped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    txDropped = property.Value.GetInt64();
                    continue;
                }
            }
            return new ContainerNetworkInterfaceStatistics(Optional.ToNullable(rxBytes), Optional.ToNullable(rxPackets), Optional.ToNullable(rxErrors), Optional.ToNullable(rxDropped), Optional.ToNullable(txBytes), Optional.ToNullable(txPackets), Optional.ToNullable(txErrors), Optional.ToNullable(txDropped));
        }
    }
}