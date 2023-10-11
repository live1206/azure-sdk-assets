// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadProtectableItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static WorkloadProtectableItem DeserializeWorkloadProtectableItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectableItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShare": return FileShareProtectableItem.DeserializeFileShareProtectableItem(element);
                    case "AzureVmWorkloadProtectableItem": return VmWorkloadProtectableItem.DeserializeVmWorkloadProtectableItem(element);
                    case "HanaHSRContainer": return AzureVmWorkloadSapHanaHSRProtectableItem.DeserializeAzureVmWorkloadSapHanaHSRProtectableItem(element);
                    case "IaaSVMProtectableItem": return IaasVmProtectableItem.DeserializeIaasVmProtectableItem(element);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectableItem.DeserializeIaasClassicComputeVmProtectableItem(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectableItem.DeserializeIaasComputeVmProtectableItem(element);
                    case "SAPAseSystem": return VmWorkloadSapAseSystemProtectableItem.DeserializeVmWorkloadSapAseSystemProtectableItem(element);
                    case "SAPHanaDBInstance": return VmWorkloadSapHanaDBInstance.DeserializeVmWorkloadSapHanaDBInstance(element);
                    case "SAPHanaDatabase": return VmWorkloadSapHanaDatabaseProtectableItem.DeserializeVmWorkloadSapHanaDatabaseProtectableItem(element);
                    case "SAPHanaSystem": return VmWorkloadSapHanaSystemProtectableItem.DeserializeVmWorkloadSapHanaSystemProtectableItem(element);
                    case "SQLAvailabilityGroupContainer": return VmWorkloadSqlAvailabilityGroupProtectableItem.DeserializeVmWorkloadSqlAvailabilityGroupProtectableItem(element);
                    case "SQLDataBase": return VmWorkloadSqlDatabaseProtectableItem.DeserializeVmWorkloadSqlDatabaseProtectableItem(element);
                    case "SQLInstance": return VmWorkloadSqlInstanceProtectableItem.DeserializeVmWorkloadSqlInstanceProtectableItem(element);
                }
            }
            return UnknownWorkloadProtectableItem.DeserializeUnknownWorkloadProtectableItem(element);
        }
    }
}