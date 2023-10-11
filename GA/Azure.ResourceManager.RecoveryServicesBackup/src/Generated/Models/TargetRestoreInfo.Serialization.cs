// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class TargetRestoreInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OverwriteOption))
            {
                writer.WritePropertyName("overwriteOption"u8);
                writer.WriteStringValue(OverwriteOption.Value.ToString());
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(TargetDirectoryForFileRestore))
            {
                writer.WritePropertyName("targetDirectoryForFileRestore"u8);
                writer.WriteStringValue(TargetDirectoryForFileRestore);
            }
            writer.WriteEndObject();
        }

        internal static TargetRestoreInfo DeserializeTargetRestoreInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RestoreOverwriteOption> overwriteOption = default;
            Optional<string> containerId = default;
            Optional<string> databaseName = default;
            Optional<string> targetDirectoryForFileRestore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overwriteOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overwriteOption = new RestoreOverwriteOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    containerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDirectoryForFileRestore"u8))
                {
                    targetDirectoryForFileRestore = property.Value.GetString();
                    continue;
                }
            }
            return new TargetRestoreInfo(Optional.ToNullable(overwriteOption), containerId.Value, databaseName.Value, targetDirectoryForFileRestore.Value);
        }
    }
}
