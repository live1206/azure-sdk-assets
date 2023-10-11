// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabDiskData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (Optional.IsDefined(DiskSizeGiB))
            {
                writer.WritePropertyName("diskSizeGiB"u8);
                writer.WriteNumberValue(DiskSizeGiB.Value);
            }
            if (Optional.IsDefined(LeasedByLabVmId))
            {
                writer.WritePropertyName("leasedByLabVmId"u8);
                writer.WriteStringValue(LeasedByLabVmId);
            }
            if (Optional.IsDefined(DiskBlobName))
            {
                writer.WritePropertyName("diskBlobName"u8);
                writer.WriteStringValue(DiskBlobName);
            }
            if (Optional.IsDefined(DiskUri))
            {
                writer.WritePropertyName("diskUri"u8);
                writer.WriteStringValue(DiskUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching"u8);
                writer.WriteStringValue(HostCaching);
            }
            if (Optional.IsDefined(ManagedDiskId))
            {
                writer.WritePropertyName("managedDiskId"u8);
                writer.WriteStringValue(ManagedDiskId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DevTestLabDiskData DeserializeDevTestLabDiskData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DevTestLabStorageType> diskType = default;
            Optional<int> diskSizeGiB = default;
            Optional<ResourceIdentifier> leasedByLabVmId = default;
            Optional<string> diskBlobName = default;
            Optional<Uri> diskUri = default;
            Optional<string> storageAccountId = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> hostCaching = default;
            Optional<ResourceIdentifier> managedDiskId = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("diskType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskType = new DevTestLabStorageType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskSizeGiB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskSizeGiB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("leasedByLabVmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leasedByLabVmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskBlobName"u8))
                        {
                            diskBlobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diskUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccountId"u8))
                        {
                            storageAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("hostCaching"u8))
                        {
                            hostCaching = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedDiskId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedDiskId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DevTestLabDiskData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(diskType), Optional.ToNullable(diskSizeGiB), leasedByLabVmId.Value, diskBlobName.Value, diskUri.Value, storageAccountId.Value, Optional.ToNullable(createdDate), hostCaching.Value, managedDiskId.Value, provisioningState.Value, Optional.ToNullable(uniqueIdentifier));
        }
    }
}