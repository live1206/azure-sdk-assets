// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SignalR;

namespace Azure.ResourceManager.SignalR.Models
{
    internal partial class SignalRSharedPrivateLinkResourceListResult
    {
        internal static SignalRSharedPrivateLinkResourceListResult DeserializeSignalRSharedPrivateLinkResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SignalRSharedPrivateLinkResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRSharedPrivateLinkResourceData> array = new List<SignalRSharedPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SignalRSharedPrivateLinkResourceData.DeserializeSignalRSharedPrivateLinkResourceData(item));
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
            return new SignalRSharedPrivateLinkResourceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
