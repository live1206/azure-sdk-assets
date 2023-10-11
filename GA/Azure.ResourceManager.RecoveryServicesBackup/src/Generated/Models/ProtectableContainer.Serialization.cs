// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class ProtectableContainer : IUtf8JsonSerializable
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
            writer.WritePropertyName("protectableContainerType"u8);
            writer.WriteStringValue(ProtectableContainerType.ToSerialString());
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
            }
            writer.WriteEndObject();
        }

        internal static ProtectableContainer DeserializeProtectableContainer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectableContainerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageContainer": return StorageProtectableContainer.DeserializeStorageProtectableContainer(element);
                    case "VMAppContainer": return VmAppContainerProtectableContainer.DeserializeVmAppContainerProtectableContainer(element);
                }
            }
            return UnknownProtectableContainer.DeserializeUnknownProtectableContainer(element);
        }
    }
}
