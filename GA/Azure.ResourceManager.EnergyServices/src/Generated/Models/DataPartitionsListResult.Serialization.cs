// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EnergyServices.Models
{
    public partial class DataPartitionsListResult
    {
        internal static DataPartitionsListResult DeserializeDataPartitionsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataPartition>> dataPartitionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataPartitionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataPartition> array = new List<DataPartition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPartition.DeserializeDataPartition(item));
                    }
                    dataPartitionInfo = array;
                    continue;
                }
            }
            return new DataPartitionsListResult(Optional.ToList(dataPartitionInfo));
        }
    }
}