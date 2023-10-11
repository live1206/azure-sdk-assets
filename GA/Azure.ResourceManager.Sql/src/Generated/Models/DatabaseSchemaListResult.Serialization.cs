// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class DatabaseSchemaListResult
    {
        internal static DatabaseSchemaListResult DeserializeDatabaseSchemaListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DatabaseSchemaData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseSchemaData> array = new List<DatabaseSchemaData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseSchemaData.DeserializeDatabaseSchemaData(item));
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
            return new DatabaseSchemaListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
