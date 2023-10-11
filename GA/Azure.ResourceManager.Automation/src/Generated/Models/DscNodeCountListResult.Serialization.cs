// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class DscNodeCountListResult
    {
        internal static DscNodeCountListResult DeserializeDscNodeCountListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DscNodeCount>> value = default;
            Optional<int> totalCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscNodeCount> array = new List<DscNodeCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscNodeCount.DeserializeDscNodeCount(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new DscNodeCountListResult(Optional.ToList(value), Optional.ToNullable(totalCount));
        }
    }
}
