// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal partial class DataLakeStoreUsageListResult
    {
        internal static DataLakeStoreUsageListResult DeserializeDataLakeStoreUsageListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataLakeStoreUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataLakeStoreUsage> array = new List<DataLakeStoreUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataLakeStoreUsage.DeserializeDataLakeStoreUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataLakeStoreUsageListResult(Optional.ToList(value));
        }
    }
}