// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsCapacityReservationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static OperationalInsightsCapacityReservationProperties DeserializeOperationalInsightsCapacityReservationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastSkuUpdate = default;
            Optional<long> minCapacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastSkuUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSkuUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("minCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCapacity = property.Value.GetInt64();
                    continue;
                }
            }
            return new OperationalInsightsCapacityReservationProperties(Optional.ToNullable(lastSkuUpdate), Optional.ToNullable(minCapacity));
        }
    }
}