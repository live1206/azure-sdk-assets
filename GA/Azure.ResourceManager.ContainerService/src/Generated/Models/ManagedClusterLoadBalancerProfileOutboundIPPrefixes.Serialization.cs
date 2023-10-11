// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPPrefixes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicIPPrefixes))
            {
                writer.WritePropertyName("publicIPPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPPrefixes)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterLoadBalancerProfileOutboundIPPrefixes DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WritableSubResource>> publicIPPrefixes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    publicIPPrefixes = array;
                    continue;
                }
            }
            return new ManagedClusterLoadBalancerProfileOutboundIPPrefixes(Optional.ToList(publicIPPrefixes));
        }
    }
}