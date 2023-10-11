// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    public partial class WebPubSubData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
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
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls"u8);
                writer.WriteObjectValue(Tls);
            }
            if (Optional.IsDefined(LiveTraceConfiguration))
            {
                writer.WritePropertyName("liveTraceConfiguration"u8);
                writer.WriteObjectValue(LiveTraceConfiguration);
            }
            if (Optional.IsDefined(ResourceLogConfiguration))
            {
                writer.WritePropertyName("resourceLogConfiguration"u8);
                writer.WriteObjectValue(ResourceLogConfiguration);
            }
            if (Optional.IsDefined(NetworkAcls))
            {
                writer.WritePropertyName("networkACLs"u8);
                writer.WriteObjectValue(NetworkAcls);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (Optional.IsDefined(IsLocalAuthDisabled))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
            }
            if (Optional.IsDefined(IsAadAuthDisabled))
            {
                writer.WritePropertyName("disableAadAuth"u8);
                writer.WriteBooleanValue(IsAadAuthDisabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebPubSubData DeserializeWebPubSubData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BillingInfoSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<WebPubSubProvisioningState> provisioningState = default;
            Optional<string> externalIP = default;
            Optional<string> hostName = default;
            Optional<int> publicPort = default;
            Optional<int> serverPort = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<WebPubSubPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<IReadOnlyList<WebPubSubSharedPrivateLinkData>> sharedPrivateLinkResources = default;
            Optional<WebPubSubTlsSettings> tls = default;
            Optional<string> hostNamePrefix = default;
            Optional<LiveTraceConfiguration> liveTraceConfiguration = default;
            Optional<ResourceLogConfiguration> resourceLogConfiguration = default;
            Optional<WebPubSubNetworkAcls> networkAcls = default;
            Optional<string> publicNetworkAccess = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> disableAadAuth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = BillingInfoSku.DeserializeBillingInfoSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new WebPubSubProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externalIP"u8))
                        {
                            externalIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebPubSubPrivateEndpointConnectionData> array = new List<WebPubSubPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebPubSubPrivateEndpointConnectionData.DeserializeWebPubSubPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebPubSubSharedPrivateLinkData> array = new List<WebPubSubSharedPrivateLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebPubSubSharedPrivateLinkData.DeserializeWebPubSubSharedPrivateLinkData(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                        if (property0.NameEquals("tls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tls = WebPubSubTlsSettings.DeserializeWebPubSubTlsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostNamePrefix"u8))
                        {
                            hostNamePrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("liveTraceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            liveTraceConfiguration = LiveTraceConfiguration.DeserializeLiveTraceConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceLogConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceLogConfiguration = ResourceLogConfiguration.DeserializeResourceLogConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkACLs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = WebPubSubNetworkAcls.DeserializeWebPubSubNetworkAcls(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableAadAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableAadAuth = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebPubSubData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity, Optional.ToNullable(provisioningState), externalIP.Value, hostName.Value, Optional.ToNullable(publicPort), Optional.ToNullable(serverPort), version.Value, Optional.ToList(privateEndpointConnections), Optional.ToList(sharedPrivateLinkResources), tls.Value, hostNamePrefix.Value, liveTraceConfiguration.Value, resourceLogConfiguration.Value, networkAcls.Value, publicNetworkAccess.Value, Optional.ToNullable(disableLocalAuth), Optional.ToNullable(disableAadAuth));
        }
    }
}