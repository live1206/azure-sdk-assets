// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class ReplicationEligibilityResultListResult
    {
        internal static ReplicationEligibilityResultListResult DeserializeReplicationEligibilityResultListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ReplicationEligibilityResultData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicationEligibilityResultData> array = new List<ReplicationEligibilityResultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationEligibilityResultData.DeserializeReplicationEligibilityResultData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ReplicationEligibilityResultListResult(Optional.ToList(value));
        }
    }
}