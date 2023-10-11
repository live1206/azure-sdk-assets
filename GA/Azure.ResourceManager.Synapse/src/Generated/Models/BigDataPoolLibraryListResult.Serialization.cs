// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class BigDataPoolLibraryListResult
    {
        internal static BigDataPoolLibraryListResult DeserializeBigDataPoolLibraryListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseLibraryData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SynapseLibraryData> array = new List<SynapseLibraryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseLibraryData.DeserializeSynapseLibraryData(item));
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
            return new BigDataPoolLibraryListResult(value, nextLink.Value);
        }
    }
}