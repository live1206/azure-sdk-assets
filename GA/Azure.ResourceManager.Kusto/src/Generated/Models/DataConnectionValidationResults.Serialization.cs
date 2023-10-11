// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class DataConnectionValidationResults
    {
        internal static DataConnectionValidationResults DeserializeDataConnectionValidationResults(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataConnectionValidationResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataConnectionValidationResult> array = new List<DataConnectionValidationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataConnectionValidationResult.DeserializeDataConnectionValidationResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataConnectionValidationResults(Optional.ToList(value));
        }
    }
}