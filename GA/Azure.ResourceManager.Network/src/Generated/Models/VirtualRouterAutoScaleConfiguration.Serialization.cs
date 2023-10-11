// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class VirtualRouterAutoScaleConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static VirtualRouterAutoScaleConfiguration DeserializeVirtualRouterAutoScaleConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minCapacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCapacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new VirtualRouterAutoScaleConfiguration(Optional.ToNullable(minCapacity));
        }
    }
}