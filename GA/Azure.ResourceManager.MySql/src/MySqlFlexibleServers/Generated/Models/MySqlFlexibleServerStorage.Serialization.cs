// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerStorage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageSizeInGB))
            {
                writer.WritePropertyName("storageSizeGB"u8);
                writer.WriteNumberValue(StorageSizeInGB.Value);
            }
            if (Optional.IsDefined(Iops))
            {
                writer.WritePropertyName("iops"u8);
                writer.WriteNumberValue(Iops.Value);
            }
            if (Optional.IsDefined(AutoGrow))
            {
                writer.WritePropertyName("autoGrow"u8);
                writer.WriteStringValue(AutoGrow.Value.ToString());
            }
            if (Optional.IsDefined(LogOnDisk))
            {
                writer.WritePropertyName("logOnDisk"u8);
                writer.WriteStringValue(LogOnDisk.Value.ToString());
            }
            if (Optional.IsDefined(AutoIoScaling))
            {
                writer.WritePropertyName("autoIoScaling"u8);
                writer.WriteStringValue(AutoIoScaling.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static MySqlFlexibleServerStorage DeserializeMySqlFlexibleServerStorage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> storageSizeGB = default;
            Optional<int> iops = default;
            Optional<MySqlFlexibleServerEnableStatusEnum> autoGrow = default;
            Optional<MySqlFlexibleServerEnableStatusEnum> logOnDisk = default;
            Optional<string> storageSku = default;
            Optional<MySqlFlexibleServerEnableStatusEnum> autoIoScaling = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("iops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iops = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoGrow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoGrow = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logOnDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logOnDisk = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageSku"u8))
                {
                    storageSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoIoScaling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoIoScaling = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
            }
            return new MySqlFlexibleServerStorage(Optional.ToNullable(storageSizeGB), Optional.ToNullable(iops), Optional.ToNullable(autoGrow), Optional.ToNullable(logOnDisk), storageSku.Value, Optional.ToNullable(autoIoScaling));
        }
    }
}
