// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeMetricDimension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType);
            writer.WritePropertyName("sourceName"u8);
            writer.WriteStringValue(SourceName);
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeMetricDimension DeserializeDataBoxEdgeMetricDimension(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceType = default;
            string sourceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceType"u8))
                {
                    sourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceName"u8))
                {
                    sourceName = property.Value.GetString();
                    continue;
                }
            }
            return new DataBoxEdgeMetricDimension(sourceType, sourceName);
        }
    }
}