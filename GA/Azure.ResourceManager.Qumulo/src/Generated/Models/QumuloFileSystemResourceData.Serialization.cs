// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Qumulo.Models;

namespace Azure.ResourceManager.Qumulo
{
    public partial class QumuloFileSystemResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("marketplaceDetails"u8);
            writer.WriteObjectValue(MarketplaceDetails);
            writer.WritePropertyName("storageSku"u8);
            writer.WriteStringValue(StorageSku.ToSerialString());
            writer.WritePropertyName("userDetails"u8);
            writer.WriteObjectValue(UserDetails);
            writer.WritePropertyName("delegatedSubnetId"u8);
            writer.WriteStringValue(DelegatedSubnetId);
            if (Optional.IsDefined(ClusterLoginUri))
            {
                writer.WritePropertyName("clusterLoginUrl"u8);
                writer.WriteStringValue(ClusterLoginUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(PrivateIPs))
            {
                writer.WritePropertyName("privateIPs"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPs)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("adminPassword"u8);
            writer.WriteStringValue(AdminPassword);
            writer.WritePropertyName("initialCapacity"u8);
            writer.WriteNumberValue(InitialCapacity);
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static QumuloFileSystemResourceData DeserializeQumuloFileSystemResourceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            MarketplaceDetails marketplaceDetails = default;
            Optional<QumuloProvisioningState> provisioningState = default;
            StorageSku storageSku = default;
            QumuloUserDetails userDetails = default;
            string delegatedSubnetId = default;
            Optional<Uri> clusterLoginUrl = default;
            Optional<IList<IPAddress>> privateIPs = default;
            string adminPassword = default;
            int initialCapacity = default;
            Optional<string> availabilityZone = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("marketplaceDetails"u8))
                        {
                            marketplaceDetails = MarketplaceDetails.DeserializeMarketplaceDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToQumuloProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("storageSku"u8))
                        {
                            storageSku = property0.Value.GetString().ToStorageSku();
                            continue;
                        }
                        if (property0.NameEquals("userDetails"u8))
                        {
                            userDetails = QumuloUserDetails.DeserializeQumuloUserDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("delegatedSubnetId"u8))
                        {
                            delegatedSubnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterLoginUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterLoginUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateIPs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            privateIPs = array;
                            continue;
                        }
                        if (property0.NameEquals("adminPassword"u8))
                        {
                            adminPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("initialCapacity"u8))
                        {
                            initialCapacity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new QumuloFileSystemResourceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, marketplaceDetails, Optional.ToNullable(provisioningState), storageSku, userDetails, delegatedSubnetId, clusterLoginUrl.Value, Optional.ToList(privateIPs), adminPassword, initialCapacity, availabilityZone.Value);
        }
    }
}