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
    internal partial class RestorableDatabaseAccountsListResult
    {
        internal static RestorableDatabaseAccountsListResult DeserializeRestorableDatabaseAccountsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RestorableCosmosDBAccountData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorableCosmosDBAccountData> array = new List<RestorableCosmosDBAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableCosmosDBAccountData.DeserializeRestorableCosmosDBAccountData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RestorableDatabaseAccountsListResult(Optional.ToList(value));
        }
    }
}