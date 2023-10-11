// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal partial class BackupManagementUsageList
    {
        internal static BackupManagementUsageList DeserializeBackupManagementUsageList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<BackupManagementUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupManagementUsage> array = new List<BackupManagementUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupManagementUsage.DeserializeBackupManagementUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BackupManagementUsageList(Optional.ToList(value));
        }
    }
}