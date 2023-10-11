// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlPerformanceTierServiceLevelObjectives
    {
        internal static PostgreSqlPerformanceTierServiceLevelObjectives DeserializePostgreSqlPerformanceTierServiceLevelObjectives(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> edition = default;
            Optional<int> vCore = default;
            Optional<string> hardwareGeneration = default;
            Optional<int> maxBackupRetentionDays = default;
            Optional<int> minBackupRetentionDays = default;
            Optional<int> maxStorageMB = default;
            Optional<int> minStorageMB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    edition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hardwareGeneration"u8))
                {
                    hardwareGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
            }
            return new PostgreSqlPerformanceTierServiceLevelObjectives(id.Value, edition.Value, Optional.ToNullable(vCore), hardwareGeneration.Value, Optional.ToNullable(maxBackupRetentionDays), Optional.ToNullable(minBackupRetentionDays), Optional.ToNullable(maxStorageMB), Optional.ToNullable(minStorageMB));
        }
    }
}