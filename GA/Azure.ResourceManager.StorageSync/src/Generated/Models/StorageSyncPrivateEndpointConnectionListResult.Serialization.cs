// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    internal partial class StorageSyncPrivateEndpointConnectionListResult
    {
        internal static StorageSyncPrivateEndpointConnectionListResult DeserializeStorageSyncPrivateEndpointConnectionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StorageSyncPrivateEndpointConnectionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageSyncPrivateEndpointConnectionData> array = new List<StorageSyncPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageSyncPrivateEndpointConnectionData.DeserializeStorageSyncPrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StorageSyncPrivateEndpointConnectionListResult(Optional.ToList(value));
        }
    }
}