// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeFileSourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("shareId"u8);
            writer.WriteStringValue(ShareId);
            writer.WriteEndObject();
        }

        internal static EdgeFileSourceInfo DeserializeEdgeFileSourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier shareId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareId"u8))
                {
                    shareId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new EdgeFileSourceInfo(shareId);
        }
    }
}