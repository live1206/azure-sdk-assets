// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtDiskContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("diskId"u8);
            writer.WriteStringValue(DiskId);
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            writer.WritePropertyName("isOSDisk"u8);
            writer.WriteStringValue(IsOSDisk);
            writer.WritePropertyName("logStorageAccountId"u8);
            writer.WriteStringValue(LogStorageAccountId);
            writer.WritePropertyName("logStorageAccountSasSecretName"u8);
            writer.WriteStringValue(LogStorageAccountSasSecretName);
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            writer.WriteEndObject();
        }
    }
}