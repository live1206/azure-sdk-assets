// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteCircuitPeeringData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringType))
            {
                writer.WritePropertyName("peeringType"u8);
                writer.WriteStringValue(PeeringType.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(AzureASN))
            {
                writer.WritePropertyName("azureASN"u8);
                writer.WriteNumberValue(AzureASN.Value);
            }
            if (Optional.IsDefined(PeerASN))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerASN.Value);
            }
            if (Optional.IsDefined(PrimaryPeerAddressPrefix))
            {
                writer.WritePropertyName("primaryPeerAddressPrefix"u8);
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SecondaryPeerAddressPrefix))
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix"u8);
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(PrimaryAzurePort))
            {
                writer.WritePropertyName("primaryAzurePort"u8);
                writer.WriteStringValue(PrimaryAzurePort);
            }
            if (Optional.IsDefined(SecondaryAzurePort))
            {
                writer.WritePropertyName("secondaryAzurePort"u8);
                writer.WriteStringValue(SecondaryAzurePort);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanId"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (Optional.IsDefined(MicrosoftPeeringConfig))
            {
                writer.WritePropertyName("microsoftPeeringConfig"u8);
                writer.WriteObjectValue(MicrosoftPeeringConfig);
            }
            if (Optional.IsDefined(Stats))
            {
                writer.WritePropertyName("stats"u8);
                writer.WriteObjectValue(Stats);
            }
            if (Optional.IsDefined(GatewayManagerETag))
            {
                writer.WritePropertyName("gatewayManagerEtag"u8);
                writer.WriteStringValue(GatewayManagerETag);
            }
            if (Optional.IsDefined(RouteFilter))
            {
                writer.WritePropertyName("routeFilter"u8);
                JsonSerializer.Serialize(writer, RouteFilter);
            }
            if (Optional.IsDefined(IPv6PeeringConfig))
            {
                writer.WritePropertyName("ipv6PeeringConfig"u8);
                writer.WriteObjectValue(IPv6PeeringConfig);
            }
            if (Optional.IsDefined(ExpressRouteConnection))
            {
                writer.WritePropertyName("expressRouteConnection"u8);
                JsonSerializer.Serialize(writer, ExpressRouteConnection);
            }
            if (Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections"u8);
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuitPeeringData DeserializeExpressRouteCircuitPeeringData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ExpressRoutePeeringType> peeringType = default;
            Optional<ExpressRoutePeeringState> state = default;
            Optional<int> azureASN = default;
            Optional<long> peerASN = default;
            Optional<string> primaryPeerAddressPrefix = default;
            Optional<string> secondaryPeerAddressPrefix = default;
            Optional<string> primaryAzurePort = default;
            Optional<string> secondaryAzurePort = default;
            Optional<string> sharedKey = default;
            Optional<int> vlanId = default;
            Optional<ExpressRouteCircuitPeeringConfig> microsoftPeeringConfig = default;
            Optional<ExpressRouteCircuitStats> stats = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<string> gatewayManagerETag = default;
            Optional<string> lastModifiedBy = default;
            Optional<WritableSubResource> routeFilter = default;
            Optional<IPv6ExpressRouteCircuitPeeringConfig> ipv6PeeringConfig = default;
            Optional<SubResource> expressRouteConnection = default;
            Optional<IList<ExpressRouteCircuitConnectionData>> connections = default;
            Optional<IReadOnlyList<PeerExpressRouteCircuitConnectionData>> peeredConnections = default;
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
                        if (property0.NameEquals("peeringType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringType = new ExpressRoutePeeringType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ExpressRoutePeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureASN"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureASN = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peerASN"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerASN = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("primaryPeerAddressPrefix"u8))
                        {
                            primaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryPeerAddressPrefix"u8))
                        {
                            secondaryPeerAddressPrefix = property0.Value.GetString();
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
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vlanId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vlanId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("microsoftPeeringConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("stats"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stats = ExpressRouteCircuitStats.DeserializeExpressRouteCircuitStats(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayManagerEtag"u8))
                        {
                            gatewayManagerETag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeFilter = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("ipv6PeeringConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv6PeeringConfig = IPv6ExpressRouteCircuitPeeringConfig.DeserializeIPv6ExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expressRouteConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteConnection = JsonSerializer.Deserialize<SubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteCircuitConnectionData> array = new List<ExpressRouteCircuitConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitConnectionData.DeserializeExpressRouteCircuitConnectionData(item));
                            }
                            connections = array;
                            continue;
                        }
                        if (property0.NameEquals("peeredConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PeerExpressRouteCircuitConnectionData> array = new List<PeerExpressRouteCircuitConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PeerExpressRouteCircuitConnectionData.DeserializePeerExpressRouteCircuitConnectionData(item));
                            }
                            peeredConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCircuitPeeringData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(peeringType), Optional.ToNullable(state), Optional.ToNullable(azureASN), Optional.ToNullable(peerASN), primaryPeerAddressPrefix.Value, secondaryPeerAddressPrefix.Value, primaryAzurePort.Value, secondaryAzurePort.Value, sharedKey.Value, Optional.ToNullable(vlanId), microsoftPeeringConfig.Value, stats.Value, Optional.ToNullable(provisioningState), gatewayManagerETag.Value, lastModifiedBy.Value, routeFilter, ipv6PeeringConfig.Value, expressRouteConnection, Optional.ToList(connections), Optional.ToList(peeredConnections));
        }
    }
}
