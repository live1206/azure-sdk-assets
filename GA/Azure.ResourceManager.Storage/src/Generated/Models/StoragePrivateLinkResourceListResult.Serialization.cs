// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class StoragePrivateLinkResourceListResult
    {
        internal static StoragePrivateLinkResourceListResult DeserializeStoragePrivateLinkResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StoragePrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StoragePrivateLinkResourceData> array = new List<StoragePrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StoragePrivateLinkResourceData.DeserializeStoragePrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StoragePrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}