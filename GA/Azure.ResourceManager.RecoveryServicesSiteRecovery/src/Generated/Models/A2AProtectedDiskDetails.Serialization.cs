// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AProtectedDiskDetails
    {
        internal static A2AProtectedDiskDetails DeserializeA2AProtectedDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> diskUri = default;
            Optional<ResourceIdentifier> recoveryAzureStorageAccountId = default;
            Optional<ResourceIdentifier> primaryDiskAzureStorageAccountId = default;
            Optional<Uri> recoveryDiskUri = default;
            Optional<string> diskName = default;
            Optional<long> diskCapacityInBytes = default;
            Optional<ResourceIdentifier> primaryStagingAzureStorageAccountId = default;
            Optional<string> diskType = default;
            Optional<bool> resyncRequired = default;
            Optional<int> monitoringPercentageCompletion = default;
            Optional<string> monitoringJobType = default;
            Optional<double> dataPendingInStagingStorageAccountInMB = default;
            Optional<double> dataPendingAtSourceAgentInMB = default;
            Optional<string> diskState = default;
            Optional<IReadOnlyList<string>> allowedDiskLevelOperation = default;
            Optional<bool> isDiskEncrypted = default;
            Optional<string> secretIdentifier = default;
            Optional<ResourceIdentifier> dekKeyVaultArmId = default;
            Optional<bool> isDiskKeyEncrypted = default;
            Optional<string> keyIdentifier = default;
            Optional<ResourceIdentifier> kekKeyVaultArmId = default;
            Optional<string> failoverDiskName = default;
            Optional<string> tfoDiskName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryDiskAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryDiskAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryDiskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryDiskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskCapacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCapacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primaryStagingAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    diskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("monitoringPercentageCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringPercentageCompletion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monitoringJobType"u8))
                {
                    monitoringJobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPendingInStagingStorageAccountInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInStagingStorageAccountInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("diskState"u8))
                {
                    diskState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedDiskLevelOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedDiskLevelOperation = array;
                    continue;
                }
                if (property.NameEquals("isDiskEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDiskEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("secretIdentifier"u8))
                {
                    secretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dekKeyVaultArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dekKeyVaultArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDiskKeyEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDiskKeyEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kekKeyVaultArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekKeyVaultArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverDiskName"u8))
                {
                    failoverDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoDiskName"u8))
                {
                    tfoDiskName = property.Value.GetString();
                    continue;
                }
            }
            return new A2AProtectedDiskDetails(diskUri.Value, recoveryAzureStorageAccountId.Value, primaryDiskAzureStorageAccountId.Value, recoveryDiskUri.Value, diskName.Value, Optional.ToNullable(diskCapacityInBytes), primaryStagingAzureStorageAccountId.Value, diskType.Value, Optional.ToNullable(resyncRequired), Optional.ToNullable(monitoringPercentageCompletion), monitoringJobType.Value, Optional.ToNullable(dataPendingInStagingStorageAccountInMB), Optional.ToNullable(dataPendingAtSourceAgentInMB), diskState.Value, Optional.ToList(allowedDiskLevelOperation), Optional.ToNullable(isDiskEncrypted), secretIdentifier.Value, dekKeyVaultArmId.Value, Optional.ToNullable(isDiskKeyEncrypted), keyIdentifier.Value, kekKeyVaultArmId.Value, failoverDiskName.Value, tfoDiskName.Value);
        }
    }
}