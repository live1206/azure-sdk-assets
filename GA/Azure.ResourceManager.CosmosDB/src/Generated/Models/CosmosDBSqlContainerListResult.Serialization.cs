// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBSqlContainerListResult
    {
        internal static CosmosDBSqlContainerListResult DeserializeCosmosDBSqlContainerListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CosmosDBSqlContainerData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBSqlContainerData> array = new List<CosmosDBSqlContainerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBSqlContainerData.DeserializeCosmosDBSqlContainerData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBSqlContainerListResult(Optional.ToList(value));
        }
    }
}