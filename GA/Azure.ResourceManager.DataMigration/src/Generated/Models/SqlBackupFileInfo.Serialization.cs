// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SqlBackupFileInfo
    {
        internal static SqlBackupFileInfo DeserializeSqlBackupFileInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fileName = default;
            Optional<string> status = default;
            Optional<long> totalSize = default;
            Optional<long> dataRead = default;
            Optional<long> dataWritten = default;
            Optional<double> copyThroughput = default;
            Optional<int> copyDuration = default;
            Optional<int> familySequenceNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataRead"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataWritten"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataWritten = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("copyThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyThroughput = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("copyDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyDuration = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("familySequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familySequenceNumber = property.Value.GetInt32();
                    continue;
                }
            }
            return new SqlBackupFileInfo(fileName.Value, status.Value, Optional.ToNullable(totalSize), Optional.ToNullable(dataRead), Optional.ToNullable(dataWritten), Optional.ToNullable(copyThroughput), Optional.ToNullable(copyDuration), Optional.ToNullable(familySequenceNumber));
        }
    }
}
