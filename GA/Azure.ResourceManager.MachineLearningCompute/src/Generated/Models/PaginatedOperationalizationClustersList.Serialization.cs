// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearningCompute;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    internal partial class PaginatedOperationalizationClustersList
    {
        internal static PaginatedOperationalizationClustersList DeserializePaginatedOperationalizationClustersList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<OperationalizationClusterData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalizationClusterData> array = new List<OperationalizationClusterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalizationClusterData.DeserializeOperationalizationClusterData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PaginatedOperationalizationClustersList(Optional.ToList(value), nextLink.Value);
        }
    }
}