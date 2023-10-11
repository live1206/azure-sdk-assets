// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoLanguageExtensionList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KustoLanguageExtensionList DeserializeKustoLanguageExtensionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<KustoLanguageExtension>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoLanguageExtension> array = new List<KustoLanguageExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoLanguageExtension.DeserializeKustoLanguageExtension(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new KustoLanguageExtensionList(Optional.ToList(value));
        }
    }
}