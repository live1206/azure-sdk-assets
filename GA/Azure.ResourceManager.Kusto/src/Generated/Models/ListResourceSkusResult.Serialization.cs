// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class ListResourceSkusResult
    {
        internal static ListResourceSkusResult DeserializeListResourceSkusResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<KustoAvailableSkuDetails>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoAvailableSkuDetails> array = new List<KustoAvailableSkuDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoAvailableSkuDetails.DeserializeKustoAvailableSkuDetails(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListResourceSkusResult(Optional.ToList(value));
        }
    }
}