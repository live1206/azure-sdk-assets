// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupDataSourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static BackupDataSourceSettings DeserializeBackupDataSourceSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BlobBackupDatasourceParameters": return BlobBackupDataSourceSettings.DeserializeBlobBackupDataSourceSettings(element);
                    case "KubernetesClusterBackupDatasourceParameters": return KubernetesClusterBackupDataSourceSettings.DeserializeKubernetesClusterBackupDataSourceSettings(element);
                }
            }
            return UnknownBackupDatasourceParameters.DeserializeUnknownBackupDatasourceParameters(element);
        }
    }
}