// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DnsResolver;

namespace Azure.ResourceManager.DnsResolver.Models
{
    internal partial class OutboundEndpointListResult
    {
        internal static OutboundEndpointListResult DeserializeOutboundEndpointListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DnsResolverOutboundEndpointData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DnsResolverOutboundEndpointData> array = new List<DnsResolverOutboundEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DnsResolverOutboundEndpointData.DeserializeDnsResolverOutboundEndpointData(item));
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
            return new OutboundEndpointListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}