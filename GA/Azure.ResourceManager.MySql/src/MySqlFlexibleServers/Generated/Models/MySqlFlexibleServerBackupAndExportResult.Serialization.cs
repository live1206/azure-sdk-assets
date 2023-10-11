// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerBackupAndExportResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DatasourceSizeInBytes))
            {
                writer.WritePropertyName("datasourceSizeInBytes"u8);
                writer.WriteNumberValue(DatasourceSizeInBytes.Value);
            }
            if (Optional.IsDefined(DataTransferredInBytes))
            {
                writer.WritePropertyName("dataTransferredInBytes"u8);
                writer.WriteNumberValue(DataTransferredInBytes.Value);
            }
            if (Optional.IsDefined(BackupMetadata))
            {
                writer.WritePropertyName("backupMetadata"u8);
                writer.WriteStringValue(BackupMetadata);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MySqlFlexibleServerBackupAndExportResult DeserializeMySqlFlexibleServerBackupAndExportResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MySqlFlexibleServerBackupAndExportOperationStatus> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<double> percentComplete = default;
            Optional<ResponseError> error = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<long> datasourceSizeInBytes = default;
            Optional<long> dataTransferredInBytes = default;
            Optional<string> backupMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToMySqlFlexibleServerBackupAndExportOperationStatus();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("percentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentComplete = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("datasourceSizeInBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            datasourceSizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("dataTransferredInBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataTransferredInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("backupMetadata"u8))
                        {
                            backupMetadata = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MySqlFlexibleServerBackupAndExportResult(id, name, type, systemData.Value, Optional.ToNullable(status), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(percentComplete), error.Value, Optional.ToNullable(datasourceSizeInBytes), Optional.ToNullable(dataTransferredInBytes), backupMetadata.Value);
        }
    }
}