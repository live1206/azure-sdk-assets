// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class SpatialSpec : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Types))
            {
                writer.WritePropertyName("types"u8);
                writer.WriteStartArray();
                foreach (var item in Types)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SpatialSpec DeserializeSpatialSpec(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<IList<CosmosDBSpatialType>> types = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("types"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBSpatialType> array = new List<CosmosDBSpatialType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CosmosDBSpatialType(item.GetString()));
                    }
                    types = array;
                    continue;
                }
            }
            return new SpatialSpec(path.Value, Optional.ToList(types));
        }
    }
}