// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlDatabasePatch : IUtf8JsonSerializable
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
                writer.WriteObjectValue(Identity);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes"u8);
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(SampleName))
            {
                writer.WritePropertyName("sampleName"u8);
                writer.WriteStringValue(SampleName.Value.ToString());
            }
            if (Optional.IsDefined(ElasticPoolId))
            {
                writer.WritePropertyName("elasticPoolId"u8);
                writer.WriteStringValue(ElasticPoolId);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId"u8);
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(SourceDatabaseDeletedOn))
            {
                writer.WritePropertyName("sourceDatabaseDeletionDate"u8);
                writer.WriteStringValue(SourceDatabaseDeletedOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryServicesRecoveryPointId))
            {
                writer.WritePropertyName("recoveryServicesRecoveryPointId"u8);
                writer.WriteStringValue(RecoveryServicesRecoveryPointId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId"u8);
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId"u8);
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId"u8);
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation"u8);
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(ReadScale))
            {
                writer.WritePropertyName("readScale"u8);
                writer.WriteStringValue(ReadScale.Value.ToString());
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount"u8);
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType"u8);
                writer.WriteStringValue(SecondaryType.Value.ToString());
            }
            if (Optional.IsDefined(AutoPauseDelay))
            {
                writer.WritePropertyName("autoPauseDelay"u8);
                writer.WriteNumberValue(AutoPauseDelay.Value);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy"u8);
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(IsLedgerOn))
            {
                writer.WritePropertyName("isLedgerOn"u8);
                writer.WriteBooleanValue(IsLedgerOn.Value);
            }
            if (Optional.IsDefined(FederatedClientId))
            {
                writer.WritePropertyName("federatedClientId"u8);
                writer.WriteStringValue(FederatedClientId.Value);
            }
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                writer.WriteStartObject();
                foreach (var item in Keys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EncryptionProtector))
            {
                writer.WritePropertyName("encryptionProtector"u8);
                writer.WriteStringValue(EncryptionProtector);
            }
            if (Optional.IsDefined(PreferredEnclaveType))
            {
                writer.WritePropertyName("preferredEnclaveType"u8);
                writer.WriteStringValue(PreferredEnclaveType.Value.ToString());
            }
            if (Optional.IsDefined(ManualCutover))
            {
                writer.WritePropertyName("manualCutover"u8);
                writer.WriteBooleanValue(ManualCutover.Value);
            }
            if (Optional.IsDefined(PerformCutover))
            {
                writer.WritePropertyName("performCutover"u8);
                writer.WriteBooleanValue(PerformCutover.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}