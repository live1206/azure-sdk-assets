// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupCopySetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static DataProtectionBackupCopySetting DeserializeDataProtectionBackupCopySetting(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CopyOnExpiryOption": return CopyOnExpirySetting.DeserializeCopyOnExpirySetting(element);
                    case "CustomCopyOption": return CustomCopySetting.DeserializeCustomCopySetting(element);
                    case "ImmediateCopyOption": return ImmediateCopySetting.DeserializeImmediateCopySetting(element);
                }
            }
            return UnknownCopyOption.DeserializeUnknownCopyOption(element);
        }
    }
}