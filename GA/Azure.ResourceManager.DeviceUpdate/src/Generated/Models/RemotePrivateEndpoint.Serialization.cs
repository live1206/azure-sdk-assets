// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class RemotePrivateEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(ImmutableSubscriptionId))
            {
                writer.WritePropertyName("immutableSubscriptionId"u8);
                writer.WriteStringValue(ImmutableSubscriptionId);
            }
            if (Optional.IsDefined(ImmutableResourceId))
            {
                writer.WritePropertyName("immutableResourceId"u8);
                writer.WriteStringValue(ImmutableResourceId);
            }
            if (Optional.IsDefined(VnetTrafficTag))
            {
                writer.WritePropertyName("vnetTrafficTag"u8);
                writer.WriteStringValue(VnetTrafficTag);
            }
            if (Optional.IsCollectionDefined(ManualPrivateLinkServiceConnections))
            {
                writer.WritePropertyName("manualPrivateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in ManualPrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateLinkServiceConnections))
            {
                writer.WritePropertyName("privateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateLinkServiceProxies))
            {
                writer.WritePropertyName("privateLinkServiceProxies"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkServiceProxies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectionDetails))
            {
                writer.WritePropertyName("connectionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RemotePrivateEndpoint DeserializeRemotePrivateEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<AzureLocation> location = default;
            Optional<string> immutableSubscriptionId = default;
            Optional<string> immutableResourceId = default;
            Optional<string> vnetTrafficTag = default;
            Optional<IList<PrivateLinkServiceConnection>> manualPrivateLinkServiceConnections = default;
            Optional<IList<PrivateLinkServiceConnection>> privateLinkServiceConnections = default;
            Optional<IList<PrivateLinkServiceProxy>> privateLinkServiceProxies = default;
            Optional<IList<ConnectionDetails>> connectionDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("immutableSubscriptionId"u8))
                {
                    immutableSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("immutableResourceId"u8))
                {
                    immutableResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vnetTrafficTag"u8))
                {
                    vnetTrafficTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manualPrivateLinkServiceConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateLinkServiceConnection> array = new List<PrivateLinkServiceConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkServiceConnection.DeserializePrivateLinkServiceConnection(item));
                    }
                    manualPrivateLinkServiceConnections = array;
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateLinkServiceConnection> array = new List<PrivateLinkServiceConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkServiceConnection.DeserializePrivateLinkServiceConnection(item));
                    }
                    privateLinkServiceConnections = array;
                    continue;
                }
                if (property.NameEquals("privateLinkServiceProxies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateLinkServiceProxy> array = new List<PrivateLinkServiceProxy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkServiceProxy.DeserializePrivateLinkServiceProxy(item));
                    }
                    privateLinkServiceProxies = array;
                    continue;
                }
                if (property.NameEquals("connectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionDetails> array = new List<ConnectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ConnectionDetails.DeserializeConnectionDetails(item));
                    }
                    connectionDetails = array;
                    continue;
                }
            }
            return new RemotePrivateEndpoint(id.Value, Optional.ToNullable(location), immutableSubscriptionId.Value, immutableResourceId.Value, vnetTrafficTag.Value, Optional.ToList(manualPrivateLinkServiceConnections), Optional.ToList(privateLinkServiceConnections), Optional.ToList(privateLinkServiceProxies), Optional.ToList(connectionDetails));
        }
    }
}