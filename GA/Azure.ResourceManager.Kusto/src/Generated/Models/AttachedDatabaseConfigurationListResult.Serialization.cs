// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class AttachedDatabaseConfigurationListResult
    {
        internal static AttachedDatabaseConfigurationListResult DeserializeAttachedDatabaseConfigurationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<KustoAttachedDatabaseConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoAttachedDatabaseConfigurationData> array = new List<KustoAttachedDatabaseConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoAttachedDatabaseConfigurationData.DeserializeKustoAttachedDatabaseConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AttachedDatabaseConfigurationListResult(Optional.ToList(value));
        }
    }
}