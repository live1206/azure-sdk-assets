// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class QuerySelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("queryString"u8);
            writer.WriteStringValue(QueryString);
            writer.WritePropertyName("subscriptionIds"u8);
            writer.WriteStartArray();
            foreach (var item in SubscriptionIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SelectorType.ToString());
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static QuerySelector DeserializeQuerySelector(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queryString = default;
            IList<string> subscriptionIds = default;
            SelectorType type = default;
            string id = default;
            Optional<Filter> filter = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryString"u8))
                {
                    queryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionIds"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subscriptionIds = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SelectorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = Filter.DeserializeFilter(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new QuerySelector(type, id, filter.Value, additionalProperties, queryString, subscriptionIds);
        }
    }
}