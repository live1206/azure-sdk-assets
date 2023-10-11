// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorTimeSeriesDataPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DateTimeUtc))
            {
                writer.WritePropertyName("dateTimeUTC"u8);
                writer.WriteStringValue(DateTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            writer.WriteEndObject();
        }

        internal static FrontDoorTimeSeriesDataPoint DeserializeFrontDoorTimeSeriesDataPoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> dateTimeUtc = default;
            Optional<float> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
            }
            return new FrontDoorTimeSeriesDataPoint(Optional.ToNullable(dateTimeUtc), Optional.ToNullable(value));
        }
    }
}