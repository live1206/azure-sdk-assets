// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlStorageUpdateSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskCount))
            {
                writer.WritePropertyName("diskCount"u8);
                writer.WriteNumberValue(DiskCount.Value);
            }
            if (Optional.IsDefined(StartingDeviceId))
            {
                writer.WritePropertyName("startingDeviceId"u8);
                writer.WriteNumberValue(StartingDeviceId.Value);
            }
            if (Optional.IsDefined(DiskConfigurationType))
            {
                writer.WritePropertyName("diskConfigurationType"u8);
                writer.WriteStringValue(DiskConfigurationType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SqlStorageUpdateSettings DeserializeSqlStorageUpdateSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> diskCount = default;
            Optional<int> startingDeviceId = default;
            Optional<SqlVmDiskConfigurationType> diskConfigurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startingDeviceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startingDeviceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskConfigurationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskConfigurationType = new SqlVmDiskConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new SqlStorageUpdateSettings(Optional.ToNullable(diskCount), Optional.ToNullable(startingDeviceId), Optional.ToNullable(diskConfigurationType));
        }
    }
}