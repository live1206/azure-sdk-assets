// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MonitoringSettings))
            {
                writer.WritePropertyName("monitoringSettings"u8);
                writer.WriteObjectValue(MonitoringSettings);
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings);
            }
            writer.WritePropertyName("storageSettings"u8);
            writer.WriteStartArray();
            foreach (var item in StorageSettings)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(FeatureSettings))
            {
                writer.WritePropertyName("featureSettings"u8);
                writer.WriteObjectValue(FeatureSettings);
            }
            writer.WriteEndObject();
        }

        internal static DataProtectionBackupVaultProperties DeserializeDataProtectionBackupVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MonitoringSettings> monitoringSettings = default;
            Optional<DataProtectionBackupProvisioningState> provisioningState = default;
            Optional<BackupVaultResourceMoveState> resourceMoveState = default;
            Optional<BackupVaultResourceMoveDetails> resourceMoveDetails = default;
            Optional<BackupVaultSecuritySettings> securitySettings = default;
            IList<DataProtectionBackupStorageSetting> storageSettings = default;
            Optional<bool> isVaultProtectedByResourceGuard = default;
            Optional<BackupVaultFeatureSettings> featureSettings = default;
            Optional<BackupVaultSecureScoreLevel> secureScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monitoringSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSettings = MonitoringSettings.DeserializeMonitoringSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataProtectionBackupProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceMoveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMoveState = new BackupVaultResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceMoveDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMoveDetails = BackupVaultResourceMoveDetails.DeserializeBackupVaultResourceMoveDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySettings = BackupVaultSecuritySettings.DeserializeBackupVaultSecuritySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("storageSettings"u8))
                {
                    List<DataProtectionBackupStorageSetting> array = new List<DataProtectionBackupStorageSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupStorageSetting.DeserializeDataProtectionBackupStorageSetting(item));
                    }
                    storageSettings = array;
                    continue;
                }
                if (property.NameEquals("isVaultProtectedByResourceGuard"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVaultProtectedByResourceGuard = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("featureSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureSettings = BackupVaultFeatureSettings.DeserializeBackupVaultFeatureSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("secureScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureScore = new BackupVaultSecureScoreLevel(property.Value.GetString());
                    continue;
                }
            }
            return new DataProtectionBackupVaultProperties(monitoringSettings.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(resourceMoveState), resourceMoveDetails.Value, securitySettings.Value, storageSettings, Optional.ToNullable(isVaultProtectedByResourceGuard), featureSettings.Value, Optional.ToNullable(secureScore));
        }
    }
}