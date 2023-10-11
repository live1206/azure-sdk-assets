// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class BackupSetInfo
    {
        internal static BackupSetInfo DeserializeBackupSetInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> backupSetId = default;
            Optional<string> firstLsn = default;
            Optional<string> lastLsn = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<BackupType> backupType = default;
            Optional<IReadOnlyList<BackupFileInfo>> listOfBackupFiles = default;
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> backupStartDate = default;
            Optional<DateTimeOffset> backupFinishedDate = default;
            Optional<bool> isBackupRestored = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupSetId"u8))
                {
                    backupSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstLsn"u8))
                {
                    firstLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastLsn"u8))
                {
                    lastLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupType = new BackupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("listOfBackupFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupFileInfo> array = new List<BackupFileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupFileInfo.DeserializeBackupFileInfo(item));
                    }
                    listOfBackupFiles = array;
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupStartDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStartDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupFinishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFinishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isBackupRestored = property.Value.GetBoolean();
                    continue;
                }
            }
            return new BackupSetInfo(backupSetId.Value, firstLsn.Value, lastLsn.Value, Optional.ToNullable(lastModifiedTime), Optional.ToNullable(backupType), Optional.ToList(listOfBackupFiles), databaseName.Value, Optional.ToNullable(backupStartDate), Optional.ToNullable(backupFinishedDate), Optional.ToNullable(isBackupRestored));
        }
    }
}