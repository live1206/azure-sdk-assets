// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHciReplicationExtensionModelCustomProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hyperVFabricArmId"u8);
            writer.WriteStringValue(HyperVFabricArmId);
            writer.WritePropertyName("azStackHciFabricArmId"u8);
            writer.WriteStringValue(AzStackHciFabricArmId);
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(StorageAccountSasSecretName))
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }

        internal static HyperVToAzStackHciReplicationExtensionModelCustomProperties DeserializeHyperVToAzStackHciReplicationExtensionModelCustomProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier hyperVFabricArmId = default;
            Optional<ResourceIdentifier> hyperVSiteId = default;
            ResourceIdentifier azStackHciFabricArmId = default;
            Optional<ResourceIdentifier> azStackHciSiteId = default;
            Optional<string> storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<Uri> asrServiceUri = default;
            Optional<Uri> rcmServiceUri = default;
            Optional<Uri> gatewayServiceUri = default;
            Optional<string> sourceGatewayServiceId = default;
            Optional<string> targetGatewayServiceId = default;
            Optional<string> sourceStorageContainerName = default;
            Optional<string> targetStorageContainerName = default;
            Optional<string> resourceLocation = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hyperVFabricArmId"u8))
                {
                    hyperVFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hyperVSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hyperVSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azStackHciFabricArmId"u8))
                {
                    azStackHciFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azStackHciSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azStackHciSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asrServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asrServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rcmServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rcmServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gatewayServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gatewayServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceGatewayServiceId"u8))
                {
                    sourceGatewayServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetGatewayServiceId"u8))
                {
                    targetGatewayServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceStorageContainerName"u8))
                {
                    sourceStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetStorageContainerName"u8))
                {
                    targetStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new HyperVToAzStackHciReplicationExtensionModelCustomProperties(instanceType, hyperVFabricArmId, hyperVSiteId.Value, azStackHciFabricArmId, azStackHciSiteId.Value, storageAccountId.Value, storageAccountSasSecretName.Value, asrServiceUri.Value, rcmServiceUri.Value, gatewayServiceUri.Value, sourceGatewayServiceId.Value, targetGatewayServiceId.Value, sourceStorageContainerName.Value, targetStorageContainerName.Value, resourceLocation.Value, subscriptionId.Value, resourceGroup.Value);
        }
    }
}