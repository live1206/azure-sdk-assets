// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupGenericProtectionContainer : IUtf8JsonSerializable
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
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
            }
            writer.WriteEndObject();
        }

        internal static BackupGenericProtectionContainer DeserializeBackupGenericProtectionContainer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("containerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupServerContainer": return BackupServerContainer.DeserializeBackupServerContainer(element);
                    case "AzureSqlContainer": return SqlContainer.DeserializeSqlContainer(element);
                    case "AzureWorkloadContainer": return WorkloadContainer.DeserializeWorkloadContainer(element);
                    case "DPMContainer": return DpmContainer.DeserializeDpmContainer(element);
                    case "GenericContainer": return GenericContainer.DeserializeGenericContainer(element);
                    case "IaasVMContainer": return IaasVmContainer.DeserializeIaasVmContainer(element);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmContainer.DeserializeIaasClassicComputeVmContainer(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmContainer.DeserializeIaasComputeVmContainer(element);
                    case "SQLAGWorkLoadContainer": return SqlAvailabilityGroupWorkloadProtectionContainer.DeserializeSqlAvailabilityGroupWorkloadProtectionContainer(element);
                    case "StorageContainer": return StorageContainer.DeserializeStorageContainer(element);
                    case "VMAppContainer": return VmAppContainerProtectionContainer.DeserializeVmAppContainerProtectionContainer(element);
                    case "Windows": return MabContainer.DeserializeMabContainer(element);
                }
            }
            return UnknownProtectionContainer.DeserializeUnknownProtectionContainer(element);
        }
    }
}
