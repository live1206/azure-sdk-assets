// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkIPAllocationListResult
    {
        internal static NetworkIPAllocationListResult DeserializeNetworkIPAllocationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<IPAllocationData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAllocationData> array = new List<IPAllocationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAllocationData.DeserializeIPAllocationData(item));
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
            return new NetworkIPAllocationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}