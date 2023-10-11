// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupRetentionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("retentionPolicyType"u8);
            writer.WriteStringValue(RetentionPolicyType);
            writer.WriteEndObject();
        }

        internal static BackupRetentionPolicy DeserializeBackupRetentionPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("retentionPolicyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LongTermRetentionPolicy": return LongTermRetentionPolicy.DeserializeLongTermRetentionPolicy(element);
                    case "SimpleRetentionPolicy": return SimpleRetentionPolicy.DeserializeSimpleRetentionPolicy(element);
                }
            }
            return UnknownRetentionPolicy.DeserializeUnknownRetentionPolicy(element);
        }
    }
}