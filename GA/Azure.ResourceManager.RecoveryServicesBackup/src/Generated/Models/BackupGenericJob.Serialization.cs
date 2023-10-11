// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupGenericJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EntityFriendlyName))
            {
                writer.WritePropertyName("entityFriendlyName"u8);
                writer.WriteStringValue(EntityFriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType);
            writer.WriteEndObject();
        }

        internal static BackupGenericJob DeserializeBackupGenericJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureIaaSVMJob": return IaasVmBackupJob.DeserializeIaasVmBackupJob(element);
                    case "AzureIaaSVMJobV2": return IaasVmBackupJobV2.DeserializeIaasVmBackupJobV2(element);
                    case "AzureStorageJob": return StorageBackupJob.DeserializeStorageBackupJob(element);
                    case "AzureWorkloadJob": return WorkloadBackupJob.DeserializeWorkloadBackupJob(element);
                    case "DpmJob": return DpmBackupJob.DeserializeDpmBackupJob(element);
                    case "MabJob": return MabBackupJob.DeserializeMabBackupJob(element);
                    case "VaultJob": return VaultBackupJob.DeserializeVaultBackupJob(element);
                }
            }
            return UnknownJob.DeserializeUnknownJob(element);
        }
    }
}