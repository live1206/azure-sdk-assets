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
    internal partial class NetworkGroupStaticMemberListResult
    {
        internal static NetworkGroupStaticMemberListResult DeserializeNetworkGroupStaticMemberListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NetworkGroupStaticMemberData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkGroupStaticMemberData> array = new List<NetworkGroupStaticMemberData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkGroupStaticMemberData.DeserializeNetworkGroupStaticMemberData(item));
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
            return new NetworkGroupStaticMemberListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}