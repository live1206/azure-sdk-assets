// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class ReplicationUsageListResult
    {
        internal static ReplicationUsageListResult DeserializeReplicationUsageListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ReplicationUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicationUsage> array = new List<ReplicationUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationUsage.DeserializeReplicationUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ReplicationUsageListResult(Optional.ToList(value));
        }
    }
}