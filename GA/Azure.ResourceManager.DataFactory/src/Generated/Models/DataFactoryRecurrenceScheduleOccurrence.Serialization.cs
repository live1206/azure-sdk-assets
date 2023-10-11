// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryRecurrenceScheduleOccurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day"u8);
                writer.WriteStringValue(Day.Value.ToSerialString());
            }
            if (Optional.IsDefined(Occurrence))
            {
                writer.WritePropertyName("occurrence"u8);
                writer.WriteNumberValue(Occurrence.Value);
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

        internal static DataFactoryRecurrenceScheduleOccurrence DeserializeDataFactoryRecurrenceScheduleOccurrence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryDayOfWeek> day = default;
            Optional<int> occurrence = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = property.Value.GetString().ToDataFactoryDayOfWeek();
                    continue;
                }
                if (property.NameEquals("occurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occurrence = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryRecurrenceScheduleOccurrence(Optional.ToNullable(day), Optional.ToNullable(occurrence), additionalProperties);
        }
    }
}