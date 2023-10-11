// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteProviderPortData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(PeeringLocation))
            {
                writer.WritePropertyName("peeringLocation"u8);
                writer.WriteStringValue(PeeringLocation);
            }
            if (Optional.IsDefined(OverprovisionFactor))
            {
                writer.WritePropertyName("overprovisionFactor"u8);
                writer.WriteNumberValue(OverprovisionFactor.Value);
            }
            if (Optional.IsDefined(PortBandwidthInMbps))
            {
                writer.WritePropertyName("portBandwidthInMbps"u8);
                writer.WriteNumberValue(PortBandwidthInMbps.Value);
            }
            if (Optional.IsDefined(UsedBandwidthInMbps))
            {
                writer.WritePropertyName("usedBandwidthInMbps"u8);
                writer.WriteNumberValue(UsedBandwidthInMbps.Value);
            }
            if (Optional.IsDefined(RemainingBandwidthInMbps))
            {
                writer.WritePropertyName("remainingBandwidthInMbps"u8);
                writer.WriteNumberValue(RemainingBandwidthInMbps.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteProviderPortData DeserializeExpressRouteProviderPortData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> portPairDescriptor = default;
            Optional<string> primaryAzurePort = default;
            Optional<string> secondaryAzurePort = default;
            Optional<string> peeringLocation = default;
            Optional<int> overprovisionFactor = default;
            Optional<int> portBandwidthInMbps = default;
            Optional<int> usedBandwidthInMbps = default;
            Optional<int> remainingBandwidthInMbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("portPairDescriptor"u8))
                        {
                            portPairDescriptor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryAzurePort"u8))
                        {
                            primaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryAzurePort"u8))
                        {
                            secondaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("peeringLocation"u8))
                        {
                            peeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overprovisionFactor"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overprovisionFactor = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("portBandwidthInMbps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            portBandwidthInMbps = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("usedBandwidthInMbps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usedBandwidthInMbps = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("remainingBandwidthInMbps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remainingBandwidthInMbps = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteProviderPortData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), portPairDescriptor.Value, primaryAzurePort.Value, secondaryAzurePort.Value, peeringLocation.Value, Optional.ToNullable(overprovisionFactor), Optional.ToNullable(portBandwidthInMbps), Optional.ToNullable(usedBandwidthInMbps), Optional.ToNullable(remainingBandwidthInMbps));
        }
    }
}