// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupGenericEngine : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(BackupEngineState))
            {
                writer.WritePropertyName("backupEngineState"u8);
                writer.WriteStringValue(BackupEngineState);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("backupEngineType"u8);
            writer.WriteStringValue(BackupEngineType.ToString());
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister"u8);
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(BackupEngineId))
            {
                writer.WritePropertyName("backupEngineId"u8);
                writer.WriteStringValue(BackupEngineId);
            }
            if (Optional.IsDefined(DpmVersion))
            {
                writer.WritePropertyName("dpmVersion"u8);
                writer.WriteStringValue(DpmVersion);
            }
            if (Optional.IsDefined(AzureBackupAgentVersion))
            {
                writer.WritePropertyName("azureBackupAgentVersion"u8);
                writer.WriteStringValue(AzureBackupAgentVersion);
            }
            if (Optional.IsDefined(IsAzureBackupAgentUpgradeAvailable))
            {
                writer.WritePropertyName("isAzureBackupAgentUpgradeAvailable"u8);
                writer.WriteBooleanValue(IsAzureBackupAgentUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(IsDpmUpgradeAvailable))
            {
                writer.WritePropertyName("isDpmUpgradeAvailable"u8);
                writer.WriteBooleanValue(IsDpmUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            writer.WriteEndObject();
        }

        internal static BackupGenericEngine DeserializeBackupGenericEngine(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("backupEngineType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupServerEngine": return BackupServerEngine.DeserializeBackupServerEngine(element);
                    case "DpmBackupEngine": return DpmBackupEngine.DeserializeDpmBackupEngine(element);
                }
            }
            return UnknownBackupEngineBase.DeserializeUnknownBackupEngineBase(element);
        }
    }
}