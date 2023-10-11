// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceLinker;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    internal partial class LinkerList
    {
        internal static LinkerList DeserializeLinkerList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<LinkerResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkerResourceData> array = new List<LinkerResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkerResourceData.DeserializeLinkerResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LinkerList(nextLink.Value, Optional.ToList(value));
        }
    }
}