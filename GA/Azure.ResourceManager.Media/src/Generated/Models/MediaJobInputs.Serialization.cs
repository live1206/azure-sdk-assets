// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobInputs : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static MediaJobInputs DeserializeMediaJobInputs(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MediaJobInputBasicProperties>> inputs = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobInputBasicProperties> array = new List<MediaJobInputBasicProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeMediaJobInputBasicProperties(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new MediaJobInputs(odataType, Optional.ToList(inputs));
        }
    }
}