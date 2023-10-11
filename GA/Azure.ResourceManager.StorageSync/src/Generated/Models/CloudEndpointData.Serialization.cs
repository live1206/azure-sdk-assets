// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    public partial class CloudEndpointData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId"u8);
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(AzureFileShareName))
            {
                writer.WritePropertyName("azureFileShareName"u8);
                writer.WriteStringValue(AzureFileShareName);
            }
            if (Optional.IsDefined(StorageAccountTenantId))
            {
                writer.WritePropertyName("storageAccountTenantId"u8);
                writer.WriteStringValue(StorageAccountTenantId.Value);
            }
            if (Optional.IsDefined(PartnershipId))
            {
                writer.WritePropertyName("partnershipId"u8);
                writer.WriteStringValue(PartnershipId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(LastWorkflowId))
            {
                writer.WritePropertyName("lastWorkflowId"u8);
                writer.WriteStringValue(LastWorkflowId);
            }
            if (Optional.IsDefined(LastOperationName))
            {
                writer.WritePropertyName("lastOperationName"u8);
                writer.WriteStringValue(LastOperationName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CloudEndpointData DeserializeCloudEndpointData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> storageAccountResourceId = default;
            Optional<string> azureFileShareName = default;
            Optional<Guid> storageAccountTenantId = default;
            Optional<string> partnershipId = default;
            Optional<string> friendlyName = default;
            Optional<string> backupEnabled = default;
            Optional<string> provisioningState = default;
            Optional<string> lastWorkflowId = default;
            Optional<string> lastOperationName = default;
            Optional<CloudEndpointChangeEnumerationStatus> changeEnumerationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("storageAccountResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureFileShareName"u8))
                        {
                            azureFileShareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("partnershipId"u8))
                        {
                            partnershipId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupEnabled"u8))
                        {
                            backupEnabled = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastWorkflowId"u8))
                        {
                            lastWorkflowId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastOperationName"u8))
                        {
                            lastOperationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("changeEnumerationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changeEnumerationStatus = CloudEndpointChangeEnumerationStatus.DeserializeCloudEndpointChangeEnumerationStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CloudEndpointData(id, name, type, systemData.Value, storageAccountResourceId.Value, azureFileShareName.Value, Optional.ToNullable(storageAccountTenantId), partnershipId.Value, friendlyName.Value, backupEnabled.Value, provisioningState.Value, lastWorkflowId.Value, lastOperationName.Value, changeEnumerationStatus.Value);
        }
    }
}