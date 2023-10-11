// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class VirtualNetworksPropertiesInfraVnetProfileVmware : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SegmentName))
            {
                writer.WritePropertyName("segmentName"u8);
                writer.WriteStringValue(SegmentName);
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworksPropertiesInfraVnetProfileVmware DeserializeVirtualNetworksPropertiesInfraVnetProfileVmware(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> segmentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("segmentName"u8))
                {
                    segmentName = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworksPropertiesInfraVnetProfileVmware(segmentName.Value);
        }
    }
}